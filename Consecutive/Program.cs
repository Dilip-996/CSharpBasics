using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
 * display a message: "Consecutive"; otherwise, display "Not Consecutive".*/
/*2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * If the user simply presses Enter, without supplying an input, exit immediately;
 * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.*/
namespace Consecutive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim();
            var inputlist = new List<int>();
            var splitinput = input.Split('-');
            if (String.IsNullOrEmpty(input))
            {
                return;
            }
            else
            {
                foreach (var i in splitinput)
                {
                    inputlist.Add(Convert.ToInt32(i));
                }
                bool isDistinct = inputlist.Count == inputlist.Distinct().Count();
                if (isDistinct)
                {
                    Console.WriteLine("Numbers are Distinct");
                }
                else
                {
                    Console.WriteLine("Duplicate");
                }
                
                bool isConsecutive = true;
                for (int i = 0; i < inputlist.Count - 1; i++)
                {

                    int value2 = inputlist[i + 1];
                    int value1 = inputlist[i];
                    if (Math.Abs(value1 - value2) != 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }
                if (isConsecutive)
                {
                    Console.WriteLine("Consecutive");
                }
                else
                    Console.WriteLine("Not Consecutive");
            }

        }
    }
}
