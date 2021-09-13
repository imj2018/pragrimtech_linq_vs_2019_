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
            //int[] numbers = { };
            //int result = numbers.First(x => x < 4);
            //int[] numbers = { 1, 3 };
            //int result = numbers.First();

            int[] numbers = { 1, 2, 4, 5, 6, 7, 8, 9};


            //int[] numbers = { };
            int result = numbers.FirstOrDefault();

            //int resultLast = numbers.Last();
            int resultLast = numbers.LastOrDefault(x => x < 5);


            //int resultElementAt = numbers.ElementAt(3);
            int resultElementAt = numbers.ElementAtOrDefault(100);


            int[] numbersSingle = { 2 };
            
            //int resultSingle = numbers.Single();
            
            //int resultSingle = numbersSingle.Single(x => x % 2 == 0);
            int resultSingle = numbersSingle.SingleOrDefault(x => x % 2 == 0);


            //int[] numbersDefaultIfEmpty = { };
            int[] numbersDefaultIfEmpty = { 1, 2, 3 };

            //IEnumerable<int> resultDefaultIfEmpty = numbersDefaultIfEmpty.DefaultIfEmpty();
            IEnumerable<int> resultDefaultIfEmpty = numbersDefaultIfEmpty.DefaultIfEmpty(100);

            foreach (var i in resultDefaultIfEmpty)
            {
                Console.Write(i);
            }
            Console.WriteLine("");


            Console.WriteLine("Result = " + result); 
            Console.WriteLine("Result = " + resultLast);
            Console.WriteLine("Result = " + resultElementAt);
            Console.WriteLine("Result = " + resultSingle);



        }


    }


}
