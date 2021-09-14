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
            string[] countries1 = { "USA", "India", "UK" };
            //string[] countries2 = { "USA", "India", "UK" };
            string[] countries2 = { "usa", "India", "uk" };

            var result = countries1.SequenceEqual(countries2);  
            var resultCaseSensitive = countries1.SequenceEqual(countries2, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Are Equal = " + result);
            Console.WriteLine("Are Equal = " + resultCaseSensitive);
            Console.WriteLine("");

            string[] countries3 = { "USA", "INDIA", "UK" };
            string[] countries4 = { "UK", "INDIA", "USA" };

            var resultUnordered = countries3.SequenceEqual(countries4);
            var resultOrderBy = countries3.OrderBy(c => c).SequenceEqual(countries4.OrderBy(c => c));

            Console.WriteLine("Are Equal = " + resultUnordered);
            Console.WriteLine("Are Equal = " + resultOrderBy);
            Console.WriteLine("");


            //  "We discussed implementing these 4 options for Distince in Part26 of LINQ Tutorial. In the same way these options
            //  can be implemented for SequenceEqual() method"

        }


    }


}
