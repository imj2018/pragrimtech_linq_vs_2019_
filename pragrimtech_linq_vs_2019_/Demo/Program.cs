using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int? result = null;
            double? result = 0;
            double? sum = 0;
            int total = 0;


            foreach (var number in Numbers)
            {
                //if (number % 2 == 0)
                //{
                //    //  if it doesn't have a value or less than the result
                //    //  store in result
                //    // 
                //    if (!result.HasValue || number < result)
                //    {
                //        result = number;
                //    }
                //}


                //if (number % 2 == 0)
                //{
                //    if (!result.HasValue || number > result)
                //    {
                //        result = number; 
                //    }
                //}


                //if (number % 2 == 0)
                //{
                //    result += number;
                //}


                //result++;
                //if (number % 2 == 0)
                //{
                //    result = result + 1;
                //}

                if (number % 2 == 0)
                {
                    sum += number;
                    total++;
                }


            }

            result = sum / total;
            
            Console.WriteLine(result);
        }
    }
}
