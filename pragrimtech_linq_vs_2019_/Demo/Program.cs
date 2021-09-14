using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    /// <summary>
    /// 
    /// skip/add comments later upon revision?
    /// 
    /// 
    /// </summary>
    class Program
    {

        public static void Main()
        {
            string[] countries = { "USA", "usa", "INDIA", "UK", "UK" };
            
            //var result = countries.Distinct();
            var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("");


            List<Employee> employees = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Mary" },
            };


            //var resultComplex = employees.Distinct();
            //var resultComplex = employees.Distinct(new EmployeeComparer());

            //  now knows how to compare objects by overriding Equals method
            // 
            //var resultComplex = employees.Distinct();

            //  can just into a new anonymous type and the and none of the above are needed
            //  anonymous types automatically override
            //  
            var resultComplex = employees.Select(x => new { x.ID, x.Name}).Distinct();

            foreach (var v in resultComplex)
            {
                Console.WriteLine(v.ID + "\t" + v.Name);
            }



        }

    }


}
