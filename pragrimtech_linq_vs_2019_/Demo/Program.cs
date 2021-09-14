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
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            IEnumerable<int> result = Enumerable.Range(1, 10).Where(x => x % 2 == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            var resultRepeat = Enumerable.Repeat("Hello", 5);

            foreach (var item in resultRepeat)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            //IEnumerable<int> data = GetData();

            //if (data != null)
            //{
            //    foreach (var item in GetData())
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine(""); 
            //}


            //  Empty is useful if the data may be coming from a somewhere else e.g a third party
            //  and may throw a null
            //
            IEnumerable<int> data = GetData() ?? Enumerable.Empty<int>();
            Console.WriteLine(data.Count());

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


        }

        public static IEnumerable<int> GetData()
        {
            //return new List<int> { 1, 2, 3 };
            return null;

        }

    }


}
