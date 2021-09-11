using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    /// <summary>
    ///  attempt without sql db
    ///  
    /// </summary>
    class Program
    {

        public static void Main()
        {
            List<Employee> employees = Employee.GetAllEmployees();

            
            IEnumerable<Employee> result = employees

                //  "So in short, use AsEnumberable operator to move query processing to the client side"

                //  AsEnumerable will break the query in 2 parts
                //  before AsEnumerable i.e the INSIDE PART, is called as a select all from in SQL which is
                //  executed as Linq-to-SQL
                // 
                //.AsEnumerable()

                //  the second part i.e OUTSIDE PART is executed after AsEnumerable on the data/objects in memory
                //  Where, OrderByDescending and Take are applied to them as Linq-to-Objects on the client side
                // 
                .Where(x => x.Gender == "Male")

                //  e.g if AsEnumerable is put here it will also include the WHERE clause in the SQL
                .AsEnumerable()
                .OrderByDescending(x => x.AnnualSalary)
                .Take(5);


            foreach (var e in result)
            {
                Console.WriteLine(e.FirstName + "\t" + e.AnnualSalary + "\t" + e.Gender); 
            }


        }


    }



}
