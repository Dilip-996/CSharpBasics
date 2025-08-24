using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

namespace NumberBetween1and100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = DivisibleByThreeCounter.Count();
            Console.WriteLine("Total count of numbers divisible by 3 between 1 and 100: " + count);
        }
    }
}
