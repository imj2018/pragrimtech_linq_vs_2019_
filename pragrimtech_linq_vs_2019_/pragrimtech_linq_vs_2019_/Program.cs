using System;
using System.Collections.Generic;
using System.Linq;

namespace pragrimtech_linq_vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName = "pragim";
            string result = strName.ChangeFirstLetterCase();


            //string result = StringHelper.ChangeFirstLetterCase(strName);


            List<int> Numbers = new List<int> { 1, 2, 3, 5, 5, 6, 7, 8, 9, 10 };
            //IEnumerable<int> EvenNumbers = Numbers.Where(n => n % 2 == 0);


            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);


            foreach (int evenNumber in EvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine(result);

        }
    }
}