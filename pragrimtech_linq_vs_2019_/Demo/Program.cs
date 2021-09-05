using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student names before sorting");
            List<Student> students = Student.GetAllStudents();

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("");


            //  OrderBy to sort students by name in ascending order
            //
            //IOrderedEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);

            //  though IOrderedEnumerable is returned IEnumerable can still be used as
            //  IOrderedEnumerable enumerable inherits from IEnumerable
            //
            IEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);

            Console.WriteLine("Students names after sorting");
            foreach (Student student in result)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("");


            //  SQL like
            //
            //  will orderby ascending by default
            //
            IOrderedEnumerable<Student> resultSQL = from student in Student.GetAllStudents()
                                                    orderby student.Name ascending
                                                    select student;

            Console.WriteLine("Students names after sorting");
            foreach (Student student in resultSQL)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("");


            IOrderedEnumerable<Student> resultDescending = Student.GetAllStudents().OrderByDescending(s => s.Name);
            
            Console.WriteLine("Students names after sorting");
            foreach (Student student in resultSQL)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("");


            IOrderedEnumerable<Student> resultSQLDescending = from student in Student.GetAllStudents()
                                                              orderby student.Name descending
                                                              select student;

            Console.WriteLine("Students names after sorting");
            foreach (Student student in resultSQLDescending)
            {
                Console.WriteLine(student.Name);
            }


        }

    }
}
