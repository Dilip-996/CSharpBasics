using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

/*3- Write a program and ask the user to enter 5 numbers. 
 * If a number has been previously entered, display an error message and ask the user to re-try. 
 * Once the user successfully enters 5 unique numbers, sort them and display 
 * the result on the console.*/
namespace Retry5UniqueNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Unique Numbers :");
            List<int> numbers = new List<int>();

            while (true)
            {
                int.TryParse(Console.ReadLine(),out int input);
                numbers.Add(input);
                bool allUnique = numbers.Count == numbers.Distinct().Count();
                if (allUnique is false)
                {
                    numbers.Remove(input);
                    Console.WriteLine("You have not entered an Unique number, Please Re-Try");
                }
                if (numbers.Count() == 5)
                {
                    break;
                }

            }
            numbers.Sort();
            Console.WriteLine("The Unique number you have entered are :");
            Console.WriteLine(string.Join(",", numbers));
            
        }
    }
}
