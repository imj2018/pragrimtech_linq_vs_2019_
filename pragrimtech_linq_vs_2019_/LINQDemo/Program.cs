using System;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "india", "USA", "UK" };

            //int result = countries.Min(x => x.Length);
            int result = countries.Max(x => x.Length);

            //Console.WriteLine("The shortest country name has {0} characters in its name",
            //    result);
            Console.WriteLine("The largest country name has {0} characters in its name",
                result);

        }
    }
}
