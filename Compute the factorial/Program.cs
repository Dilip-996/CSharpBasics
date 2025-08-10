using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

namespace Compute_the_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to calculate its factorial");
            int Result = 1;
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Result *= i;
            }
            Console.WriteLine("{0} Factorial = {1}",number,Result);
        }
    }
}
