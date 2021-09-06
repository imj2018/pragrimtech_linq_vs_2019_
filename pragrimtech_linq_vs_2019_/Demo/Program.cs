using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> listStudents = new List<Student>()
            {
                new Student { StudentID = 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID = 102, Name = "Mary", TotalMarks = 900  },
                new Student { StudentID = 103, Name = "Pam", TotalMarks = 800  }
            };


            //  "LINQ operators can be broadly classified into 2 categories based on the behaviour of query execution
            //  1.Deferred or Lazy Operators - These query operators use deferred execution.Examples - select, where, Take, Skip etc
            //  2.Immediate or Greedy Operators - These query operators use immediate execution.Examples - count, average, min, max, ToList etc"


            //  if the query executed is executed Tim should not be in the result, 
            //  Tim is in the result so the query is not executed where is defined therefore
            //  it is known as deferred execution
            // 
            //IEnumerable<Student> result = from student in listStudents
            //                              where student.TotalMarks == 800
            //                              select student;


            //  an immediate operator like ToList will force the query to execute where it is defined
            //  therefore Tim will not be added to the List
            // 
            //IEnumerable<Student> result = (from student in listStudents
            //                               where student.TotalMarks == 800
            //                               select student).ToList();


            //  Count is also an immediate or greedy operator
            //
           int result = (from student in listStudents
                         where student.TotalMarks == 800
                         select student).Count();


            listStudents.Add(new Student() { StudentID = 104, Name = "Tim", TotalMarks = 800 });


            //foreach (Student student in result)
            //{
            //    Console.WriteLine(student.StudentID + "\t" + student.Name + "\t" + student.TotalMarks);           
            //}

            Console.WriteLine("Total = " + result);



        }

    }
}
