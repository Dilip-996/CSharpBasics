using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2- Write a program and ask the user to enter their name. 
 Use an array to reverse the name and then store the result in a new string.
 Display the reversed name on the console.*/

namespace ReversedName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name :");
            string name = Console.ReadLine();
            
            char[]chars= name.ToCharArray();

            Array.Reverse(chars);
            string Rname = new string(chars);
            Console.WriteLine("The Reversed Name is : {0}",Rname);
            
        }
    }
}
