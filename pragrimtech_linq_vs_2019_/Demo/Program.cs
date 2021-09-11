using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    /// <summary>
    /// test ammend
    /// 
    /// </summary>
    class Program
    {

        public static void Main()
        {
   
            var employeeGroups = from employee in Employee.GetAllEmployees()              
                                 group employee by employee.Department into eGroup
                                 orderby eGroup.Key
                                 select new
                                 {
                                     Key = eGroup.Key,
                                     Employees = eGroup.OrderBy(x => x.Name)
                                 };



            foreach (var group in employeeGroups)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Employees.Count());
                Console.WriteLine("------------");

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
