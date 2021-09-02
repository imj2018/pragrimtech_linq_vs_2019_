using System;
using System.Collections.Generic;
using System.Linq;

namespace pragrimtech_linq_vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> evenNumbers = from number in numbers
                                            where (number % 2) == 0
                                            select number;

            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
