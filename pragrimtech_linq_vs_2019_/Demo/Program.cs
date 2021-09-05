using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  SelectMany to retrieve all the students subjects
            // 
            //  the lambda expression is applied to all student objects in the List of students
            // 
            //  "What is Select many going to do, this is going to project all the subjects of a
            //  given student to a single IEnumerable of string... We have got 4 students so there
            //  will be 4 IEnumberable of strings, all of them will be flattened/combined to form a single
            //  IEnumberable of string"
            //
            //IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects);

            //  SQL like syntax
            //
            //  the second from clause will get its data from the first from clause i.e 
            //  the first from clause will get the List of all students, the second will
            //  will get all the Subjects
            // 
            //IEnumerable<string> subjects = from student in Student.GetAllStudents()
            //                               from subject in student.Subjects
            //                               select subject;


            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            //  two IEnumberable of character sequences that will be flattened/combined to form a single
            //  IEnumberable of character sequence
            //
            //IEnumerable<char> result = stringArray.SelectMany(s => s);

            //  SQL like syntax
            //
            //IEnumerable<char> result = from s in stringArray
            //                           from c in s
            //                           select c;

            //foreach (char c in result)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine("");

            //  multiple students are enrolled in C#, Distince can be used
            //  to filter out multiple results that are the same
            //  
            //IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects).Distinct();

            //  SQL like syntax
            //
            //  invoke Distict on the results on this query i.e use of open brackets
            // 
            //IEnumerable<string> subjects = (from student in Student.GetAllStudents()
            //                              from subject in student.Subjects
            //                              select subject).Distinct();


            //  the student name and subject
            //  
            //  s => s.Subjects to get the List of subjects, create two variables (student, subject)
            //  then project into a new anonymous type 
            // 
            //  the StudentName will get all the names front the student variable, the other property
            //  SubjectName will get it's value from subject
            //  
            var result = Student.GetAllStudents()
                .SelectMany(s => s.Subjects, 
                (student, subject) => new { 
                    StudentName = student.Name, 
                    SubjectName = subject 
                } );

            var resultSQL = from student in Student.GetAllStudents()
                            from subject in student.Subjects
                            select new { StudentName = student.Name, SubjectName = subject };

            foreach (var v in resultSQL)
            {
                Console.WriteLine(v.StudentName + " - " + v.SubjectName);
            }

        }

    }
}
