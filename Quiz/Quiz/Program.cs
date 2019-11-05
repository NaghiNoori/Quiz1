using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. write a C# method to take N and generate paramide with N
            Program.pyramid();

            // 2. write a C# method to create a function to calculate the sum of the individual digits of a givin number
            //Program.sumOfDigits();

            // 3. write a C# program to calculate the n!
            // Program.factorial();
        }

        static void pyramid()
        {
            Console.WriteLine("Input number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void sumOfDigits()
        {
            Console.WriteLine("Enter at least 2 digits: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            while (n > 0)
            {
                result += n % 10;
                n /= 10;
            }

            Console.WriteLine($"The sum is {result}");
            Console.Read();
        }

        static void factorial()
        {
            int i, j = 1, n;

            Console.Write("Enter an integer: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
                j = j * i;

            Console.Write($"The Factorial of {n} is: {j}\n");
            Console.ReadLine();

        }

    }
}























