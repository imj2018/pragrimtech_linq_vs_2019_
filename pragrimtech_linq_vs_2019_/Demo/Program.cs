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
            //  for the inner join only the matching elements between two collections
            //  will be returned
            // 
            //var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
            //                                        e => e.DepartmentID,
            //                                        d => d.ID,
            //                                        (employee, department) => new
            //                                        {
            //                                            EmployeeName = employee.Name,
            //                                            DepartmentName = department.Name,
            //                                        });


            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d.Name
                         };


            foreach (var employee in result)
            {
                Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
            }



        }

    }


}
