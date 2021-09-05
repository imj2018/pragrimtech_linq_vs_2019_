using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int TotalMarks { get; set; }

        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student { StudentID = 101, TotalMarks = 800, Name = "Tom", Gender = "Male", Subjects = new List<string> { "ASP.NET", "C#" } },
                new Student { StudentID = 104, TotalMarks = 800, Name = "John", Gender = "Male", Subjects = new List<string> { "ADO.NET", "C#", "AJAX" } },
                new Student { StudentID = 105, TotalMarks = 800, Name = "John", Gender = "Male", Subjects = new List<string> { "WCF.NET", "SQL Server", "C#" } },
                new Student { StudentID = 102, TotalMarks = 900, Name = "Mary", Gender = "Female", Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" } },
                new Student { StudentID = 103, TotalMarks = 800, Name = "Pam", Gender = "Female", Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" } },


            };

            return listStudents;
        }
     
    }
}
