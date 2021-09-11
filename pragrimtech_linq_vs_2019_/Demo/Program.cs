using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    /// <summary>
    /// 
    /// skip/add comments later upon revision?
    /// 
    /// 
    /// </summary>
    class Program
    {

        public static void Main()
        {
            //var employeeGroups = Employee.GetAllEmployees()
            //    .GroupBy(x => new { x.Department, x.Gender })
            //    .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
            //    .Select(g => new
            //    {
            //        Dept = g.Key.Department,
            //        Gender = g.Key.Gender,
            //        Employees = g.OrderBy(x => x.Name)
            //    });


            //  SQL like
            // 
            var employeeGroups = from employee in Employee.GetAllEmployees()
                                 group employee by new { employee.Department, employee.Gender } into eGroup
                                 orderby eGroup.Key.Department, eGroup.Key.Gender
                                 select new
                                 {
                                     Dept = eGroup.Key.Department,
                                     Gender = eGroup.Key.Gender,
                                     Employees = eGroup.OrderBy(x => x.Name)
                                 };

            foreach (var group in employeeGroups)
            {
                Console.WriteLine("{0} department {1} employees count = {2}",
                    group.Dept, group.Gender, employeeGroups.Count());
                Console.WriteLine("--------------------------------------------");

                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Gender + "\t" + employee.Department);
                }
                Console.WriteLine("");
                Console.WriteLine("");


            }

        }


    }



}
