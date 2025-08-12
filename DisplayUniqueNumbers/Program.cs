using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/
namespace DisplayUniqueNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the numbers continuously : ");
            List<int> numbers = new List<int>();
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {

                    break;
                }
                numbers = numbers.Distinct().ToList();
                if (int.TryParse(userInput, out int input))
                {
                    numbers.Add(input);
                }

            }
            numbers.Sort();
            Console.WriteLine("The Unique numbers are : {0}", string.Join(",", numbers));
        }
    }
}
