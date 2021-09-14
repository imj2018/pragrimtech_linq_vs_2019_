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
            //  List of employees will be the left collection and list of Departments 
            //  will be the right collection
            // 
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID into employeesGroup
                         from d in employeesGroup.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = e.Name,
                             //DeparmentName = d
                             DepartmentName = d == null? "No Department" : d.Name
                         };

            foreach (var v in result)
            {
                Console.WriteLine(v.EmployeeName + "\t" + v.DepartmentName);
            }
            Console.WriteLine("");


            var resultsMethod = Employee.GetAllEmployees().GroupJoin(Department.GetAllDepartments(),
                                                            e => e.DepartmentID, d => d.ID,
                                                            (employee, departments) => new
                                                            {
                                                                employee,
                                                                departments
                                                            })
                                                            .SelectMany(z => z.departments.DefaultIfEmpty(),
                                                            (a, b) => new
                                                            {
                                                                EmployeeName = a.employee.Name,
                                                                DepartmentName = b == null ? "No Department" : b.Name
                                                            });

            foreach (var v in resultsMethod)
            {
                Console.WriteLine(v.EmployeeName + "\t" + v.DepartmentName);
            }


        }

    }


}
