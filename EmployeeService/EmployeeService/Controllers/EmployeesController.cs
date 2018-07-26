using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        EmployeeDBEntities ent = new EmployeeDBEntities();

        [HttpGet]
        public IEnumerable<Employee> ShowAll()
        {
            return ent.Employees.ToList();
        }
        public HttpResponseMessage Get(int id)
        {

            var en = ent.Employees.FirstOrDefault(e => e.ID == id);
            if (en != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, en);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "id " + id + "not found");
            }

        }
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {

                ent.Employees.Add(employee);
                ent.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri +
                        employee.ID.ToString());

                    return message;
               
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Delete(int id)
        {
            try
            {
               
                    var entity = ent.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                            "Employee with Id = " + id.ToString() + " not found to delete");
                    }
                    else
                    {
                    ent.Employees.Remove(entity);
                    ent.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Put(int id, [FromBody]Employee employee)
        {
            try
            {
                
                    var entity = ent.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                            "Employee with Id " + id.ToString() + " not found to update");
                    }
                    else
                    {
                        entity.FirstName = employee.FirstName;
                        entity.LastName = employee.LastName;
                        entity.Gender = employee.Gender;
                        entity.Salary = employee.Salary;

                    ent.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
               
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }

}
