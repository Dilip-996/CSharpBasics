using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//5- Write a program and ask the user to enter a series of numbers separated by comma.
//Find the maximum of the numbers and display it on the console.
//For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
namespace MaxOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by comma");
            string input = Console.ReadLine();
            int[] part = input
                .Split(',')
                .Select(x=>int.Parse(x))
                .ToArray();
            int max = part.Max();
            Console.WriteLine("maximum of the number : {0}",max);
        }
    }
}
