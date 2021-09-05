using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Select returns an IEnumerable List of List of strings
            //  
            IEnumerable<List<string>> result = Student.GetAllStudents().Select(x => x.Subjects);

            //  as it is returning a List of List of strings a nested foreach is needed
            //
            foreach (List<string> stringList in result)
            {
                foreach (string str in stringList)
                {
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine("");


            //  SelectMany is returning just an IEnumberable of string unlike Select it is not
            //  returning a List of List of a given type, it flattens the List of a given type 
            //  into a single List
            // 
            IEnumerable<string> resultSelectMany = Student.GetAllStudents().SelectMany(x => x.Subjects);

            foreach (string str in resultSelectMany)
            {
                Console.WriteLine(str);
            }

        }

    }
}
