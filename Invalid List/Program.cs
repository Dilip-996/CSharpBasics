using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Invalid_List
{
    /* 5- Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
         If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
         otherwise, display the 3 smallest numbers in the list.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers;

            while (true)
            {
                numbers = new List<int>();
                Console.WriteLine("Please enter Comma seperated numbers(e.g 5, 1, 9, 2, 10):");
                var inputlist = Console.ReadLine();

                string[] parts = inputlist.Split(',');
                foreach (string part in parts)
                {
                    if (int.TryParse(part.Trim(), out int input))
                    {
                        numbers.Add(input);
                    }
                }
                if (numbers.Count < 5)
                {
                    if (numbers.Count>1)
                    {
                        Console.WriteLine($"Invalid List (you entered {numbers.Count} numbers). Please try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid List (you entered {numbers.Count} number). Please try again.");
                    }
                    

                }
                else
                {
                    break;
                }

            }
            numbers.Sort();
            Console.WriteLine("the 3 smallest numbers in the list are : {0},{1},{2}", numbers[0], numbers[1], numbers[2]);

        }
    }
}
