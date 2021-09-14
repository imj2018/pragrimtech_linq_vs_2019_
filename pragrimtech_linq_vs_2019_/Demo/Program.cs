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
            //  Cross Join/Cartesian product will be the product of the two sequences which is 10, does not use
            //  the on keyword 
            //
            //var result = from e in Employee.GetAllEmployees()
            //             from d in Department.GetAllDepartments()


            var result = from d in Department.GetAllDepartments()
                         from e in Employee.GetAllEmployees()
                         select new { e, d };


            foreach (var v in result)
            {
                Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            }
            Console.WriteLine("");


            //var resultMethod = Employee.GetAllEmployees()
            //                           .SelectMany(e => Department.GetAllDepartments(),
            //                           (e, d) => new { e, d });

            var resultMethod = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
                                                            e => true,
                                                            d => true,
                                                            (e, d) => new { e, d });

            foreach (var v in resultMethod)
            {
                Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            }
            Console.WriteLine("");


        }

    }


}
