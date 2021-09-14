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
            //  Department.GetAllDepartments is the outer sequence, Employee.GetAllEmployees() is
            //  the inner
            //
            //var employeesByDepartment = Department.GetAllDepartments()
            //                                      .GroupJoin(Employee.GetAllEmployees(),
            //                                      d => d.ID,
            //                                      e => e.DepartmentID,
            //                                      (department, employees) => new
            //                                      {
            //                                          Department = department,
            //                                          Employees = employees
            //                                      }) ;


            // SQL like
            //
            var employeesByDepartment = from d in Department.GetAllDepartments()
                                        join e in Employee.GetAllEmployees()
                                        on d.ID equals e.DepartmentID into eGroup
                                        select new
                                        {
                                            Department = d,
                                            Employees = eGroup
                                        };


            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name + " " + department.Department.ID);
                
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine("");
            }

 



        }


    }


}
