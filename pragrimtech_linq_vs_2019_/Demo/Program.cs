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


            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 1, 3, 6, 7, 8 };

            //  "Union combines two collections into one collection while removing duplicate elements."
            //
            var result = numbers1.Union(numbers2);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("");


            List<Employee> employees1 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"},
                new Employee { ID = 103, Name = "Mary" },
            };

            List<Employee> employees2 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 104, Name = "John"}
            };

            //  like Distinct will not compare the properties of the object, can be solved
            //  the same way by projecting an anonymous type
            // 
            //var resultComplex = employees1.Union(employees2);
            var resultComplex = employees1.Select(x => new { x.ID, x.Name })
                                          .Union(employees2.Select(x => new { x.ID, x.Name }));

            foreach (var v in resultComplex)
            {
                Console.WriteLine(v.ID + "\t" + v.Name);
            }
            Console.WriteLine("");


            var resultIntersect = numbers1.Intersect(numbers2);

            foreach (var v in resultIntersect)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("");

            var resultExcept = numbers1.Except(numbers2);

            foreach (var v in resultExcept)
            {
                Console.WriteLine(v);
            }


        }

    }


}
