using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  returns an IEnumerable<int> collection i.e a List of all employee IDs
            // 
            //IEnumerable<int> results = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);

            //foreach (int id in results)
            //{
            //    Console.WriteLine(id);
            //}


            //  project first name and gender to an anonymous type
            //  "an anonymous type is a type that does not contain contain a name that's why we are simply 
            //  saying new"
            // 
            //  Select is returning an anonymous type i.e IEnumerable<'a> so we cannot denote the type of
            //  IEnumberable returned so var cant be used
            // 
            //var results = Employee.GetAllEmployees().Select(emp => new { emp.FirstName, emp.Gender });

            //foreach (var v in results)
            //{
            //    Console.WriteLine(v.FirstName + " - " + v.Gender);
            //}


            //  projecting a new a anonymous type, settings its own properties
            // 
            //var results = Employee.GetAllEmployees()
            //    .Select(emp => new
            //    { 
            //        FullName = emp.FirstName + " " + emp.LastName, 
            //        Gender = emp.Gender, 
            //        MonthlySalary = emp.AnnualSalary / 12 
            //    });

            //foreach (var v in results)
            //{
            //    Console.WriteLine(v.FullName + " - " + v.Gender + " - " + v.MonthlySalary);
            //}


            //  project a new anonymous type with a 10% bonus if annual salary exceeds 50000
            var results = Employee.GetAllEmployees()
                .Where(x => x.AnnualSalary > 50000)
                .Select(emp => new
                {
                    Name = emp.FirstName,
                    AnnualSalary = emp.AnnualSalary,
                    Bonus = emp.AnnualSalary * .1
                });

            foreach (var v in results)
            {
                Console.WriteLine(v.Name + " : " + v.AnnualSalary + " - " + v.Bonus);
            }
        }

    }
}
