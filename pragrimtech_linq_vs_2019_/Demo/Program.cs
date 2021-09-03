using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4, 5, 6, 7, 8, 9, 10 };

            //  the lambda matches the requirements of the Func<int, bool>
            //  x is int, x % 2 == 0 is a bool e.g if it were x + 2 for the expression
            //  it would return an error as it return an int
            // 
            //IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);


            //  explicitely use and pass a Func (generic delegate)
            //  
            //Func<int, bool> predicate = x => x % 2 == 0;
            //IEnumerable<int> evenNumbers = numbers.Where(predicate);


            //IEnumerable<int> evenNumbers = numbers.Where(num => isEven(num));


            //  look like SQL, T-SQL
            //
            //IEnumerable<int> evenNumbers = from num in numbers
            //                               where num % 2 == 0
            //                               select num;


            //  the second parameter can be used to get the index of each
            //
            //  this will throw an error as it is returning an anonymous type therefore
            //  the var keyword can be used, it will contain IEnumerable of the anonymous 
            //  type new { Number = num, Index = index }
            //
            //var result = numbers.Select((num, index) => new { Number = num, Index = index });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Number + " - " + item.Index);
            //}


            //  only even numbers
            //
            //var result = numbers
            //    .Select((num, index) => new { Number = num, Index = index })
            //    .Where(x => x.Number % 2 == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Number + " - " + item.Index);
            //}

            //  returning only the Index it will only return the Index which is
            //  type integer dnot as an anonymous object unlike before
            //
            var result = numbers
                .Select((num, index) => new { Number = num, Index = index })
                .Where(x => x.Number % 2 == 0)
                .Select(x => x.Index);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }

        private static bool isEven(int number)
        {
            //if (number % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return number % 2 == 0;
        }

    }
}
