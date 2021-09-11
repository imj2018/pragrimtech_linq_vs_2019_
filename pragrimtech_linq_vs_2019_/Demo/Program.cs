using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {

        public static void Main()
        {
            ArrayList list = new ArrayList()
            {
                1,
                2,
                3,

                //  will throw an error as Cast attempts to cast all items to type int
                //
                "4",
                "ABC"
            };


            //  Cast will attempt to cast all elements to type int
            //  as it is deferred/lazy it will be thrown in the loop
            // 
            IEnumerable<int> result = list.Cast<int>();


            //  will only return elements of that type 
            //
            IEnumerable<int> resultOfType = list.OfType<int>();


            foreach (int i in resultOfType)           
            {
                Console.WriteLine(i);
            }





        }


    }

}
