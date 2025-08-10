using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
//Calculate the sum of all the previously entered numbers and display it on the console.

namespace EnterOKtoExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum =0;
            while (true)
            {
                Console.WriteLine("Enter numbers to sum them up. Type 'ok' to exit.");
                string number = Console.ReadLine();
                if (number.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    int.TryParse(number, out int output);
                    sum += output;
                }

            }
            Console.WriteLine("sum of all the previously entered numbers : {0}",sum);
        }
    }
}