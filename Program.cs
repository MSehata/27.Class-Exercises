using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Class_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            swapTwoNumbers();
            absoluteValue(-76);
            isLeapYear();
            IfNumberContains3(433);                     
            SieveOfEratosthenes(30);            
            Console.WriteLine("Extracted String is: " + ExtractString("++#--#++"));
            Console.WriteLine("There are " + HowManyOccurrences("Moloko is good", "is") + " occurance(s).");

            Console.Read();
        }

        static void swapTwoNumbers()
        {
            Console.WriteLine("Method Swap Two Number Started");
            Console.WriteLine("------------------------------");
            Console.Write("Enter first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Your first integer is " + a + " and your second integer is " + b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("After a swap: Your first integer is " + a + " and your second integer is " + b);

            Console.WriteLine("Method Swap Two Number Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        public static int absoluteValue(int a)
        {
            Console.WriteLine("Method absoluteValue Started");
            Console.WriteLine("------------------------------");
            Console.WriteLine("The absolute Value of " + a + " is " + Math.Abs(a));
            Console.WriteLine("Method Absolute Value Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            return a;
            
        }

        public static void isLeapYear()
        {
            Console.WriteLine("Method isLeapYear Started");
            Console.WriteLine("------------------------------");
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))                
                Console.WriteLine("Year " + year + " is a Leap year");                
            else
                Console.WriteLine("Year " + year + " is not a Leap year");

            Console.WriteLine("Method isLeapYear Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();              
            
        }

        public static bool IfNumberContains3(int number)
        {
            Console.WriteLine("Method IfNumberContains 3 Started");
            Console.WriteLine("------------------------------");
            while (number > 0)
            {
                int digit = number % 10;
                if (digit == 3)
                {
                    Console.WriteLine("True");
                    return true;
                }             
                    
                number /= 10;
            }
            Console.WriteLine("False");
            Console.WriteLine("Method isLeapYear Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            return false;
        }

        public static List<int> SieveOfEratosthenes(int n)
        {
            Console.WriteLine("Method SieveOfEratosthenes Started");
            Console.WriteLine("------------------------------");
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine("Prime numbers in the range [2, {0}]:", n);
            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Method SieveOfEratosthenes Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            return primes;
        }

        public static string ExtractString(string input)
        {
            Console.WriteLine("Method ExtractString Started");
            Console.WriteLine("------------------------------");
            int firstHashIndex = input.IndexOf("##");
            int lastHashIndex = input.LastIndexOf("##");

            if (firstHashIndex != -1 && lastHashIndex != -1 && firstHashIndex < lastHashIndex)
            {
               
            
                return input.Substring(firstHashIndex + 2, lastHashIndex - firstHashIndex - 2);
            }


            Console.WriteLine("Method ExtractString Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            return string.Empty;
        }

        public static int HowManyOccurrences(string mainString, string substring)
        {
            Console.WriteLine("Method HowManyOccurrences Started");
            Console.WriteLine("------------------------------");
            int count = 0;
            int index = mainString.IndexOf(substring);

            while (index != -1)
            {
                count++;
                index = mainString.IndexOf(substring, index + 1);
            }

            Console.WriteLine("Method HowManyOccurrences Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
           return count;
        }
    }
}
