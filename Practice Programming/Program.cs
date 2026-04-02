using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee("Dilip", 90000);
            Employee emp2 = new Employee("Ravi", 20000);
            Employee emp3 = new Employee("John", 30000);
            Employee emp4 = new Employee("Alex", 40000);
            Employee emp5 = new Employee("Sam", 50000);
            Employee emp6 = new Employee("Vidhya", 500000);
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            employees.Add(emp6);
            var result = employees.Where(e => e.Salary >= 50000).OrderByDescending(e=>e.Salary).Select(e => e.Name.ToUpper()).First();
            var result1 = employees.Where(e => e.Salary >= 40000).OrderByDescending(e=>e.Salary).Take(2);
            var count = employees.Where(e=>e.Salary>=40000).Count();
            var check = employees.Where(e => e.Salary > 100000).Any();
            var category = employees.GroupBy(e =>
            {
                if (e.Salary>=100000)
                {
                    return "High";
                }
                else if (e.Salary>=50000)
                {
                    return "Medium";
                }
                else
                {
                    return "Low";
                }
            });
            foreach (var group in category)
            {
                Console.WriteLine("\nCategory: {0}",group.Key);
                foreach (var emp in group)
                {
                    Console.WriteLine("{0} {1}",emp.Name,emp.Salary);
                }
            }


            //Console.WriteLine(category);
            //Console.WriteLine(count);
            //Console.WriteLine(check);

        }

    }
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(string name,int salary)
        {
            Name = name;
            Salary = salary;
        }
            
    }

}