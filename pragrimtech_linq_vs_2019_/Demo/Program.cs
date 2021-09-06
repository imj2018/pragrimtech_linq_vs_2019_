using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                IEnumerable<Student> students = Student.GetAllStudents();

                Console.WriteLine("Please enter Page Number - 1,2,3 or 4");

                int pageNumber = 0;

                if (int.TryParse(Console.ReadLine(), out pageNumber))
                {
                    if (pageNumber >= 1 && pageNumber <= 4)
                    {
                        int pageSize = 3;

                        //  e.g if the user has entered page 1 get the first 3 records 
                        //  and do not skip any records. if the user enters 1 then 1 - 1 = 0 * 3
                        //  is 0 so no pages will be skipped.
                        //  
                        //students.Skip((pageNumber - 1) * pageSize);

                        //  Take 3 records or objects i.e pageSize
                        //  if user enters 2 then 2 - 1 = 1 * 3 is 3, so skip 3 for then take/get
                        //  the next 3 i.e 104, 105, 106
                        //  
                        //students.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                        //  store them to print
                        IEnumerable<Student> result = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                        Console.WriteLine("");
                        Console.WriteLine("Displaying Page " + pageNumber);
                        foreach (Student student in result)
                        {
                            Console.WriteLine(student.StudentID + "\t" + student.Name + "\t" + student.TotalMarks);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Page number must be an integer between 1 and 4");
                    }
                }
                else
                {
                    Console.WriteLine("Page number must be an integer between 1 and 4");
                }

            } while (true);

        }

    }
}
