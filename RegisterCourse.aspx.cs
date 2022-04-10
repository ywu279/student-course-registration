using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lab8.Models;

namespace lab8
{
    public partial class RegisterCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) //load the page for the first time
            {   
                //display a dropdown list of students added from AddStudent.aspx page
                if (Session["studentList"] == null)
                {
                    Response.Redirect("AddStudent.aspx");
                }
                else
                {
                    List<Student> studentList = (List<Student>)Session["studentList"];
                    foreach (Student s in studentList)
                    {
                        ListItem listItem = new ListItem(s.ToString());
                        drpStudent.Items.Add(listItem);
                         
                    }
                }

                //display all available courses
                List<Course> courseList = Helper.GetAvailableCourses();
                foreach (Course c in courseList)
                {
                    ListItem listItem = new ListItem
                    {
                        Text = $" · {c.Code} {c.Title} - {c.WeeklyHours} hours per week",
                        Value = c.Code
                    };
                    checkList.Items.Add(listItem);
                }
            }
        }


        protected void drpStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = drpStudent.SelectedIndex;
            if (index == 0)
            {
                foreach (ListItem listItem in checkList.Items)
                {
                    listItem.Selected = false;
                }
            }
            else
            {
                //display pre-checked courses the student has already registered
                List<Student> studentList = (List<Student>)Session["studentList"];
                List<Course> registeredCourses = studentList[index - 1].RegisteredCourses;
                if (registeredCourses.Count != 0)
                {
                    foreach (ListItem listItem in checkList.Items)
                    {
                        listItem.Selected = false;
                        foreach (Course s in registeredCourses)
                        {
                            if (listItem.Value == s.Code)
                            {
                                listItem.Selected = true;
                            }
                        }
                    }
                }
                else
                {
                    foreach (ListItem listItem in checkList.Items)
                    {
                        listItem.Selected = false;
                    }
                }

                lblSummary.Visible = true;
                lblSummary.Text = $"Selected student has registered {registeredCourses.Count} course(s), {studentList[index - 1].TotalWeeklyHours(registeredCourses)} hours weekly";
            }

            
        }
        

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Abort the event if the page isn't valid.
            if (!Page.IsValid) return;
   
            try
            {
                //generate a list of selected courses
                List<Course> selected = new List<Course>();
                foreach (ListItem listItem in checkList.Items)
                {
                    if (listItem.Selected)
                    {
                        Course course = Helper.GetCourseByCode(listItem.Value);
                        selected.Add(course);
                    }
                }
                //put selected courses into the "RegisteredCourses" for that particular student s
                List<Student> studentList = (List<Student>)Session["studentList"];
                Student s = studentList[drpStudent.SelectedIndex - 1];
                s.RegisterCourses(selected);


                if (IsPostBack)
                {
                    int hours = s.TotalWeeklyHours(selected);
                    int count = selected.Count;
                    if (count == 0)
                    {
                        lblSummary.Visible = false;
                        lblCheckListError.Visible = true;
                        lblCheckListError.Text = "You need select at least one course";
                    }
                    else
                    {
                        lblCheckListError.Visible = false;
                        lblSummary.Visible = true;
                        lblSummary.Text = $"Selected student has registered {count} course(s), {hours} hours weekly";
                    }
                }

            }
            catch (Exception ex)
            {
                lblSummary.Visible = false;
                lblCheckListError.Visible = true;
                lblCheckListError.Text = ex.Message;
            }
        }  
    }
}