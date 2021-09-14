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
            //  Group Join is similar to outer join in SQL i.e even records with no matching elements
            //  between collections will be returned. hierarchal data structure so two foreach loops are neeed
            // 
            var result = from d in Department.GetAllDepartments()
                         join e in Employee.GetAllEmployees()
                         on d.ID equals e.DepartmentID into employeeGroup
                         select new
                         {
                             Department = d,
                             Employees = employeeGroup
                         };

            foreach (var department in result)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine("");
            }


            //  Inner Join will create a flat result with a 1 to 1 mapping, so department XX with no matching
            //  elements between collections will  be excluded. similar to the inner join in SQL. 
            //  flat so only one foreach is needed
            // 

            var resultInner = from e in Employee.GetAllEmployees()
                              join d in Department.GetAllDepartments()
                              on e.DepartmentID equals d.ID
                              select new { e, d };

            foreach (var employee in resultInner)
            {
                Console.WriteLine(employee.e.Name + "\t" + employee.d.Name);
            }



        }

    }


}
