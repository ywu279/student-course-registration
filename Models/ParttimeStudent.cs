using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab8.Models;

namespace lab8.Models
{
    public class ParttimeStudent : Student
    {
        public static int MaxNumOfCourses { get; set; }

        //Constructor
        public ParttimeStudent(string name) : base(name)
        {

        }

        //Method
        public override void RegisterCourses(List<Course> selectedCourses)
        {
            int totalCourses = selectedCourses.Count;
            if (totalCourses > MaxNumOfCourses)
            {
                throw new Exception($"The total number of registered courses exceeds Maximum number of courses: {MaxNumOfCourses}");
            }
            else
            {
                base.RegisterCourses(selectedCourses);
            }
        }

        public override string ToString()
        {
            return base.ToString() + " (Part time)";
        }
    }
}