using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lab8.Models;

namespace lab8
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected List<Student> studentList;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //always test the object does exist in Session before use it
            if (Session["studentList"] != null)
            {
                studentList = (List<Student>)Session["studentList"]; //retrieve session
            }
            else
            {
                studentList = new List<Student>();
                Session["studentList"] = studentList;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Abort the event if the page isn't valid.
            if (!Page.IsValid) return;
            
            tblStudent.Rows.Remove(noStudentError);

            if(drpStudentType.SelectedIndex == 1)
            {
                FulltimeStudent fulltime = new FulltimeStudent(txtStudentName.Text);
                studentList.Add(fulltime);
            }
            else if (drpStudentType.SelectedIndex == 2)
            {
                ParttimeStudent parttime = new ParttimeStudent(txtStudentName.Text);
                studentList.Add(parttime);
            }
            else if(drpStudentType.SelectedIndex == 3)
            {
                CoopStudent coop = new CoopStudent(txtStudentName.Text);
                studentList.Add(coop);
            }

            Session["studentList"] = studentList; //store a list of student objects into session

            foreach (Student s in studentList)
            {
                tblStudent.Rows.Add(new TableRow
                {
                    Cells =
                    {
                        new TableCell{ Text = s.Id.ToString() },
                        new TableCell{ Text = s.Name }
                    }
                });
            }

            //empty the TextBox and DropDownList
            txtStudentName.Text = "";
            drpStudentType.SelectedIndex = 0;
            
        }
    }
}