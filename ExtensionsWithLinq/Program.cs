using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsWithLinq
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            AddEmployees();

            Console.WriteLine("...Extension with Linq...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Linq to get details of Mushtaq with Linq-FirstOrDefault");
            Console.WriteLine();
            Console.WriteLine(employees.Where(x => x.Name.Contains("Mushtaq")).FirstOrDefault().String());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Linq to get details of Mushtaq with Linq-LastOrDefault");
            Console.WriteLine();
            Console.WriteLine(employees.Where(x => x.Name.Contains("Mushtaq")).LastOrDefault().String());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Linq to get index of Mushtaq with Linq-IndexOf");
            Console.WriteLine();
            Console.WriteLine(employees.IndexOf(employees.Where(x => x.Name.Contains("Mushtaq")).FirstOrDefault()));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Linq to get details of Mushtaq with Linq-FirstOrDefault Extension");
            Console.WriteLine();
            Console.WriteLine(employees.WhereFirstOrDefault(x => x.Name.Contains("Mushtaq")).String());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Linq to get details of Mushtaq with Linq-LastOrDefault Extension");
            Console.WriteLine();
            Console.WriteLine(employees.WhereLastOrDefault(x => x.Name.Contains("Mushtaq")).String());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Linq to get index of Mushtaq with Linq-IndexOf Extension");
            Console.WriteLine();
            Console.WriteLine(employees.IndexOf(x => x.Name.Contains("Mushtaq")));

            Console.ReadLine();

            /*List<Employee> employees = new List<Employee>();
            employees.IndexOf(x => x.Name.Contains("Mushtaq"));
            string str = "test";
            Console.WriteLine(str.IsNullOrEmpty());
            object[] objArray = new object[10];
            objArray.Clear();*/

        }

        static void AddEmployees()
        {
            employees.Add(new Employee() { Name = "Mushtaq", MobileNo = "9876543210", Salary = "20K" });
            employees.Add(new Employee() { Name = "Mohammed Mushtaq", MobileNo = "9876543211", Salary = "30K" });
            employees.Add(new Employee() { Name = "Mushtaq Ahmed", MobileNo = "9876543212", Salary = "20K" });
            employees.Add(new Employee() { Name = "Raj", MobileNo = "9876543213", Salary = "25K" });
        }
    }
}
