using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "india", "USA", "UK" };

            int? result = null;

            foreach (string str in countries)
            {
                //  if that has less characters store in result
                // 
                //if (!result.HasValue || str.Length < result)
                //{
                //    result = str.Length;
                //}

                if (!result.HasValue || str.Length > result)
                {
                    result = str.Length;
                }
            }

            //Console.WriteLine("The shortest country name has {0} characters in its name",
            //    result);
            Console.WriteLine("The longest country name has {0} characters in its name",
                result);

        }
    }
}
