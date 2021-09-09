using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            //  converting with ToList is a greedy operator
            //  
            List<int> result = numbers.ToList();

            foreach (int i in result)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("");


            List<string> countries = new List<string>() { "US", "India", "UK", "Australia", "Canada" };

            //  converting with ToArray is a greedy operator
            //
            string[] resultArray = countries.OrderBy(c => c).ToArray();

            foreach (string str in resultArray)
            {
                Console.Write(str + "\t");
            }
            Console.WriteLine("");


            List<Student> listStudents = new List<Student>()
            {
                new Student { StudentID = 101, TotalMarks = 800, Name = "Tom", Gender = "Male", Subjects = new List<string> { "ASP.NET", "C#" } },
                new Student { StudentID = 102, TotalMarks = 900, Name = "Mary", Gender = "Female", Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" } },
                new Student { StudentID = 103, TotalMarks = 800, Name = "Pam", Gender = "Female", Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" } },
                //new Student { StudentID = 103, TotalMarks = 800, Name = "XYZ", Gender = "Female", Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" } },

            };

            //  ToDictionary is also greedy
            //
            Dictionary<int, string> dictionaryIDNames =
                listStudents.ToDictionary(x => x.StudentID, x => x.Name);

            foreach (KeyValuePair<int, string> kvp in dictionaryIDNames)
            {
                Console.WriteLine(kvp.Key + "\t" + kvp.Value);
            }
            Console.WriteLine("");


            //  by just using the keySelector i.e StudentID the value will be a 
            //  Student object itself (first overloaded version)
            // 
            //Dictionary<int, Student> dicionaryStudents = listStudents.ToDictionary(x => x.StudentID);

            //  can also use elementSelector to specify the value for the same result
            // 
            Dictionary<int, Student> dicionaryStudents = listStudents.ToDictionary(x => x.StudentID, x => x);


            foreach (KeyValuePair<int, Student> kvp in dicionaryStudents)
            {
                Console.WriteLine(kvp.Key + "\t" + kvp.Value.Name + "\t" + kvp.Value.TotalMarks);
            }
            Console.WriteLine("");


            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "Pam", JobTitle = "Developer", City = "London" }
            };
            

            //  ILookup will group the employees based on job title
            //  
            ILookup<string, Employee> employeesByJobTitle = listEmployees.ToLookup(x => x.JobTitle);

            Console.WriteLine("Employees Grouped by Job Title");
            
            foreach (IGrouping<string, Employee> kvp in employeesByJobTitle)
            {
                //  first loop will print out the key which is job title
                // 
                Console.WriteLine(kvp.Key);

                //  foreach key there are multiple values, employeesByJobTitle is the lookup when opening
                //  square brackets it immediately asks for a key, as we are iterating through another loop
                //  we want the employee related to that key
                foreach (var employee in employeesByJobTitle[kvp.Key])
                {
                    Console.WriteLine("\t" + employee.Name + "\t" + employee.JobTitle + "\t" + employee.City);
                }
            }
            Console.WriteLine("");


            //  ILookup based on city
            // 
            //  the second argument can be an elementSelector, either pass the entire Employee object
            //  or specific properties (by default it's the entire Employee object)
            //
            var employeesByCity = listEmployees.ToLookup(x => x.City);

            Console.WriteLine("Employees Grouped by City");

            foreach (IGrouping<string, Employee> kvp in employeesByCity)
            {
                //  first loop will print out the key which is job title
                // 
                Console.WriteLine(kvp.Key);

                //  foreach key there are multiple values, employeesByJobTitle is the lookup when opening
                //  square brackets it immediately asks for a key, as we are iterating through another loop
                //  we want the employee related to that key
                foreach (var employee in employeesByCity[kvp.Key])
                {
                    Console.WriteLine("\t" + employee.Name + "\t" + employee.JobTitle + "\t" + employee.City);
                }
            }



        }

        public class Employee
        {
            public string Name { get; set; }
            public string JobTitle { get; set; }
            public string City { get; set; }
        }



    }
}
