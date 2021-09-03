using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] countries = { "India", "USA", "UK", "Canada", "Australia" };

            //string result = string.Empty;

            //foreach (var str in countries)
            //{
            //    //result = result + str + ", ";
            //    result += str + ", ";
            //}

            //int lastIndex = result.LastIndexOf(",");
            //result = result.Remove(lastIndex);

            //Console.WriteLine(result);


            int[] Numbers = { 2, 3, 4, 5 };

            int result = 1;

            foreach (int number in Numbers)
            {
                result = result * number;
            }

            Console.WriteLine(result);

        }
    }
}
