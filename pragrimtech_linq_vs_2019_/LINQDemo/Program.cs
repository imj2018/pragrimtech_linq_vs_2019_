using System;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int result = Numbers.Min();

            //  Where will return a list of integers as all even numbers i.e filer them outs
            //  from that list, Min will then return the smallest even number
            //  
            //int result = Numbers.Where(x => x % 2 == 0).Min();

            //int result = Numbers.Where(x => x % 2 == 0).Max();


            //int result = Numbers.Sum();

            //int result = Numbers.Where(x => x % 2 == 0).Sum();


            //int result = Numbers.Count();

            //int result = Numbers.Where(x => x % 2 == 0).Count();


            //double result = Numbers.Average();

            double result = Numbers.Where(x => x % 2 == 0).Average();



            Console.WriteLine(result);
        }
    }
}
