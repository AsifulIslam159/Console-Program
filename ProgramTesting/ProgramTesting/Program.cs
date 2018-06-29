using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ProgramTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int str, i, j, k;
            Console.WriteLine("Enter level: ");
            str = int.Parse(Console.ReadLine());
            
            
            #region Piramid upper
            for (i = 1; i <= str; i++)
            {

                for (k = i; k <= str; k++)
                {
                   Console.Write(" ");
               }
               for (j = 1; j <= i; j++)
               {
                  Console.Write("* ");
              }
              Console.WriteLine();
            }
            #endregion
                
                
            #region piramid lower
            for (i = 1; i <= str; i++)
            {
                for (k = 1; k < i; k++)
                {
                    Console.Write(" ");
               }
               for (j = i; j <= str; j++)
               {
                   Console.Write("* ");
                }

                Console.WriteLine();
            }
            #endregion
                
                
                
            #region Alphabet Piramid
            char ch = 'A';
            int i, j, k, m;
            for (i = 1; i <= 10; i++)
            {
                for (j = 10; j >= i; j--)
                   Console.Write(" ");
               for (k = 1; k <= i; k++)
                   Console.Write(ch++);
               ch--;
               for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
            #endregion
                
                
            #region Copy queue element to an array
            int[] arr = new int[5];
            Queue Q = new Queue(5);
            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue(40);
            Q.CopyTo(arr, 1);
            Console.WriteLine("Items are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\tItem[" + (i + 1) + "]: " + arr[i]);
            }
            #endregion
                
                
                
            #region Febonacci
            int fibo = 1, add = 0, i, n, s;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
               if (i <= 0)
                {
                   Console.Write(i);
                }
                else
               {
                    s = add + fibo;
                    fibo = add;
                   add = s;
                    Console.Write(s);
               }

            }
            #endregion
                
                
                
            #region Prime number or not
            int n;
            bool flag = true;
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
               }
            }
            if (flag == true)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
            #endregion
                
                
            #region Prime number in range
            int range;
            bool flag = false;
            range = int.Parse(Console.ReadLine());
            for (int k = range; k >= 2; k--)
            {
                for (int i = 2; i < k; i++)
                {
                    if (k % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.Write(k + " ");
                }
                flag = false;
            }
            #endregion
                
                
            #region Factorial
            int fact;
            fact = int.Parse(Console.ReadLine());
            for (int i = fact - 1; i > 0; i--)
            {

                fact = fact * i;
            }
            if (fact == 0)
            {
                fact = 1;
            }
            Console.WriteLine(fact);
            #endregion
                
                
            #region Factorial with recursion
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            long fact = GetFactorial(number);
            Console.WriteLine("{0} factorial is {1}", number, fact);
            Console.ReadKey();
            #endregion
                
                
            #region File read write
            string s;
            Console.WriteLine("Enter text to writee in the file");
            s = Console.ReadLine();
            File.AppendAllText("File.txt", s);
            Console.WriteLine("Done");
            string t = File.ReadAllText("File.txt");
            Console.WriteLine(t);
            #endregion
                
                
            #region Bubble sort
                int[] swap = new int[5];
                for (int j = 0; j < swap.Length; j++)
                {
                    swap[j] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i <= swap.Length; i++)
                {

                    for (int K = 0; K < swap.Length - 1; K++)
                    {
                        if (swap[K] > swap[K + 1])
                        {
                            int temp = swap[K + 1];
                            swap[K + 1] = swap[K];
                            swap[K] = temp;

                        }
                    }
                }
                Console.WriteLine("After Sort: ");
                for (int l = 0; l < swap.Length; l++)
                {
                    Console.WriteLine(swap[l].ToString());
                }
                Console.ReadKey();

            #endregion
                
                
            #region sum of each digit in an integer
            int m, count = 0;
            int n = 767587;
            int lenght = n.ToString().Length;
            while (lenght >= 0)
            {
                m = n % 10;
                n = n / 10;
                count = count + m;
                lenght--;
            }
            Console.WriteLine(count);
            #endregion
                
                
                
            #region Reverse integer
            int reverse = 0;
            Console.WriteLine("Input an Interger");
            int rev = int.Parse(Console.ReadLine());
            int len = rev.ToString().Length;
            while (len > 0)
            {
                reverse = reverse * 10;
                reverse = reverse + rev % 10;
                rev = rev / 10;
                len--;
            }
            Console.WriteLine(reverse);
            #endregion
                
                
            Console.WriteLine(Palindrome.IsPalindrome("level"));
            
            
            #region Armstrong number
            int range, number, store, i, sum = 0, s1;
            number = int.Parse(Console.ReadLine());
            store = number;

            int lngth = number.ToString().Length;
            for (i = 0; i < lngth; i++)
            {
                s1 = number % 10;
                long s2 = (long)Math.Pow(s1, lngth);
                number = number / 10;
                sum = (int)s2 + sum;
            }
            if (sum == store)
            {
                Console.WriteLine(store + " is an Amstrong number");
            }
            else
            {
                Console.WriteLine(store + " is not an Amstrong number");
            }
            #endregion
                
                
            #region Armstrong number in range
            int range, number, store, sum = 0, s1;
            long s2;
            Console.WriteLine("Enter the Range ");
            range = int.Parse(Console.ReadLine());
            for (int r = 1; r <= range; r++)
            {
                store = r;
                int lngth = store.ToString().Length;
                for (int i = 0; i < lngth; i++)
                {
                    s1 = store % 10;
                    s2 = (long)Math.Pow(s1, lngth);
                    store = store / 10;
                    sum = (int)s2 + sum;
                }
                if (sum == r && sum != 0)
                {
                    Console.WriteLine(sum);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    continue;
                }
            }
            #endregion
                
                
            #region Leap year
            int lpYr;
            Console.WriteLine("Enter a Year");
            Console.WriteLine();
            lpYr = int.Parse(Console.ReadLine());
            if (lpYr % 4 == 0)
            {
                Console.WriteLine("{0} Leap Year",lpYr);
            }
            else
            {
                Console.WriteLine("{0} Not a Leap Year",lpYr);
            }
            #endregion
                
                
                
            #region binary triangle
            int binary = 0, i, j, n,k;
            Console.WriteLine("Enter level: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = i; j < n-1; j++)
                {
                    Console.Write(" ");
                }
                for (k=1;k<=i;k++)
                    {
                        Console.Write(binary + " ");
                        if (binary == 0)
                        {
                            binary = 1;
                        }
                       else if (binary == 1)
                        {
                           binary = 0;
                        }
                   }
                Console.WriteLine();
            }
            #endregion
                
                
                
        }
        
        
        
        #region Factorial with recursion
        private static long GetFactorial(int number)

        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
        #endregion
    }


    #region check reverse string is same or not(Palindrome)
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
       {
           char[] arr = word.ToCharArray();
           Array.Reverse(arr);
          string newString = new string(arr);
          if (newString.Equals(word, StringComparison.InvariantCultureIgnoreCase))
         {
              return true;
           }
           else
          {
               return false;
           }
        }
    }
    #endregion


   
    
}

