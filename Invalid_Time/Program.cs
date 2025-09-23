using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Time
{
    /*3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
     * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
     * otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00).");
            var input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            if (TimeSpan.TryParse(input, out TimeSpan inputTime))
            {
                if (inputTime > TimeSpan.Zero && inputTime < TimeSpan.FromHours(24))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
