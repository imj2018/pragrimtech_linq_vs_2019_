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
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 1, 4, 5 };

            //  unlike union Concat will combine both sequences into one sequence but will not
            //  remove duplicates
            //
            var result = numbers1.Concat(numbers2);

            foreach (var v in result) 
            {
                Console.WriteLine(v);
            }

        }


    }


}
