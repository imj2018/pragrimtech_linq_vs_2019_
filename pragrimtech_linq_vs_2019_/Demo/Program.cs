using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    class Program
    {

        public static void Main()
        {
            //  GroupBy will return IEnumberable<IGrouping<string, Employee>>
            //
            //  employeeGroups will store two groups of employees, one group will have the key
            //  "HR" with all employees belonging to the "HR" Department the other will have the "IT"...
            //
            //var employeeGroups = Employee.GetAllEmployees().GroupBy(x => x.Department);


            //  SQL like
            //var employeeGroups = from employee in Employee.GetAllEmployees()
            //                     group employee by employee.Department;


            //  there is no sorting for the employees or the departments
            //
            //  we want to sort the departments first in ascending order, then each employee within
            //  each department should be sorted
            //
            var employeeGroups = from employee in Employee.GetAllEmployees()

                                     //  store the employees in a variable called eGroup
                                     //
                                 group employee by employee.Department into eGroup

                                 //  orderby by the Key property which is the department name
                                 //  so the groups will be sorted by Key in ascending order i.e HR then IT 
                                 //
                                 orderby eGroup.Key

                                 //  project a new anonymous type, employeeGroups will now have
                                 //  two groups with these two properties
                                 // 
                                 select new
                                 {
                                     Key = eGroup.Key,
                                     //Employees = eGroup

                                     //  call OrderBy to sort the names as they are not in ascending order
                                     Employees = eGroup.OrderBy(x => x.Name)
                                 };


            foreach (var group in employeeGroups)
            {
                //  to reiterate these are all aggregate functions
                // 
                //Console.WriteLine("{0} - {1}", group.Key, group.Count());
                //Console.WriteLine("{0} - {1}", group.Key, group.Count(x => x.Gender == "Male"));
                //Console.WriteLine("{0} - {1}", group.Key, group.Max(x => x.Salary));
                //Console.WriteLine("{0} - {1}", group.Key, group.Min(x => x.Salary));
                //Console.WriteLine("{0} - {1}", group.Key, group.Sum(x => x.Salary));


                //Console.WriteLine("{0} - {1}", group.Key, group.Count());
                Console.WriteLine("{0} - {1}", group.Key, group.Employees.Count());
                Console.WriteLine("------------");

                //  group contains the Department as a the key and the employees belonging to that group
                //  therefore we can loop through to get each employee object in the group
                //
                //foreach (var employee in group)

                //  the employees are no longer present in group, they are now in the Employees
                //  property i.e they have been projected into the Employees property
                //
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Department);
                }
                Console.WriteLine("");
                Console.WriteLine("");

            }


        }


    }



}
