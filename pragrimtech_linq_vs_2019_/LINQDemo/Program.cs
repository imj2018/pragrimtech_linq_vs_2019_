using System;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] countries = { "India", "USA", "UK", "Canada", "Australia" };

            //  (a, b)?
            //  Aggregate will take India and USA into a and b and combine them with a comma ","
            //  which will be the result of the first execution. "India, USA" is stored into a 
            //  while the third element UK is stored into b, it then performs the operation a + ", " + b
            //  to combine them together again and store them into a which will then be "India, USA, UK"
            //  while the fourth element Canada is then stored into b, it will perform the operation again until
            //  reaching the last element in the sequence
            // 
            //string result = countries.Aggregate((a, b) => a + ", " + b);


            int[] Numbers = { 2, 3, 4, 5 };

            //  to reiterate
            //  take first two elements in the sequence which are a = 2, b = 3 then
            //  perform the operation a * b. take the result store that into a (a = 6)
            //  then take the next element which is 4 into b then perform the operation...
            //
            //int result = Numbers.Aggregate((a, b) => a * b);

            //  seed parameter
            //  take the seed parameter into a, then the first element in the sequence which
            //  is 2 into b then perform the operation a * b. take the result 20 and store that
            //  into a then take the next element which is 3 into b then perform the operation...
            //
            int result = Numbers.Aggregate(10, (a, b) => a * b);



            Console.WriteLine(result);

        }
    }
}
