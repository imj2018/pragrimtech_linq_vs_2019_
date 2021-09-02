using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IEnumerable<Student> queryResult = Student.GetAllStudents().Where(student => student.Gender == "Male");

            IEnumerable<Student> queryResult = from student in Student.GetAllStudents()
                                               where student.Gender == "Male"
                                               select student;


            GridView1.DataSource = queryResult;
            GridView1.DataBind();

        }
    }
}