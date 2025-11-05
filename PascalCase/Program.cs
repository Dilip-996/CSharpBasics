using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCase
{
    /*4- Write a program and ask the user to enter a few words separated by a space. 
     * Use the words to create a variable name with PascalCase. 
     * For example, if the user types: "number of students", display "NumberOfStudents". 
     * Make sure that the program is not dependent on the input. 
     * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by a space");
            var input = Console.ReadLine().Trim().ToLower(); ;
            var names = new List<string>();

            var inputNames = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in inputNames)
            {
                names.Add(item);
            }
            for (int i = 0; i < names.Count; i++)
            {
                var letters = names[i].ToCharArray();

            }


        }
    }
}
