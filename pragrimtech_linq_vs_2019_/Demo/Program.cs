using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  using another order by will sort the results by ascending order
            //  but what we want is total marks in ascending order then names in
            //  ascending order
            //
            //IOrderedEnumerable<Student> result = Student.GetAllStudents()
            //    .OrderBy(s => s.TotalMarks).OrderBy(s => s.Name);


            //  first OrderBy for the primary sort for total marks then
            //  the results should be sorted by name with ThenBy in ascending order
            //  for Name
            IOrderedEnumerable<Student> result = Student.GetAllStudents()
                .OrderBy(s => s.TotalMarks).ThenBy(s => s.Name);

            foreach (var s in result)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);

            }
            Console.WriteLine("");
            

            //  ThenByDescending to sort by student ID in descending
            //  
            IOrderedEnumerable<Student> resultThenByDescending = Student.GetAllStudents()
                .OrderBy(s => s.TotalMarks)
                .ThenBy(s => s.Name)
                .ThenByDescending(s => s.StudentID);

            foreach (var s in resultThenByDescending)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);

            }
            Console.WriteLine("");


            //  SQL like
            //
            //  ordeby seperated by commas, the properties will be ordered by ascending by default
            //  except the student ID which will be descending
            // 
            IOrderedEnumerable<Student> resultSql = from s in Student.GetAllStudents()
                                                    orderby s.TotalMarks, s.Name, s.StudentID descending
                                                    select s;

            foreach (var s in resultSql)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);

            }
            Console.WriteLine("");


            IEnumerable<Student> students = Student.GetAllStudents();        
            Console.WriteLine("Before calling Reverse Method");
            foreach (Student s in students)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);

            }
            Console.WriteLine("");


            IEnumerable<Student> resultReverse = students.Reverse();
            Console.WriteLine("After calling Reverse Method");
            foreach (Student s in resultReverse)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);

            }



        }

    }
}
