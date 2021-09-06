using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            //  Take will return the first 3 country names   
            //
            IEnumerable<string> result = countries.Take(3);

            //  SQL like
            //
            IEnumerable<string> resultSql = (from country in countries
                                            select country).Take(3);


            //  Skip will skip the elements then return the remaining  
            // 
            IEnumerable<string> resultSkip = countries.Skip(3);


            //  TakeWhile, the lambda will be executed against every item to check if true
            //  then return each string greater than 2
            // 
            IEnumerable<string> resultTakeWhile = countries.TakeWhile(c => c.Length > 2);

            IEnumerable<string> resultTakeWhileSql = (from c in countries
                                                      select c).TakeWhile(c => c.Length > 2);


            //  SkipWhile will execute until the condition is false i.e it gets to US 
            //  then will return the remaning 
            //  
            IEnumerable<string> resultSkipWhile = countries.SkipWhile(c => c.Length > 2);

            IEnumerable<string> resultSkipWhileSql = (from c in countries
                                                      select c).SkipWhile(c => c.Length > 2);

            foreach (var str in resultSkipWhileSql)
            {
                Console.WriteLine(str);
            }
        }

    }
}
