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
            int[] numbers = { 1, 2, 3, 4, 5 };
            

            //  all elements are less than 10
            //  
            var result = numbers.All(x => x < 10);

            var resultAny = numbers.Any();
            var resultAnyCondition = numbers.Any(x => x < 10);

            var resultContains = numbers.Contains(3);

            string[] countries = { "USA", "INDIA", "UK" };

            var resultContainsCaseSensitive = countries.Contains("india", StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(result);
            Console.WriteLine(resultAny);
            Console.WriteLine(resultAnyCondition);
            Console.WriteLine(resultContains);
            Console.WriteLine(resultContainsCaseSensitive);


            List<Employee> employees = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Rosy"},
                new Employee {ID = 102, Name = "Susy"}
            };

            //  will only check the object reference
            //
            var resultComplex = employees.Contains(new Employee { ID = 101, Name = "Rosy" });

            // solve using projection
            // 
            var resultComplexProject = employees.Select(x => new { x.ID, x.Name }).Contains(new { ID = 101, Name = "Rosy" });

            Console.WriteLine(resultComplex);
            Console.WriteLine(resultComplexProject);

        }


    }


}
