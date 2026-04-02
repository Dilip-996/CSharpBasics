using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            person dilip = new person();
            
            Console.WriteLine(dilip.name);

        }
    }
    class person
    {
        public string name="qwerty";
        public int age=29;
    }
}