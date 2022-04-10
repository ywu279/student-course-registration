using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab8.Models;

namespace lab8.Models
{
    public class FulltimeStudent : Student
    {
        public static int MaxWeeklyHours { get; set; }

        //Constructor
        public FulltimeStudent(string name) : base(name)
        {

        }

        //Method
        public override void RegisterCourses(List<Course> selectedCourses)
        {
            int totalWeeklyHours = TotalWeeklyHours(selectedCourses);
            if (totalWeeklyHours > MaxWeeklyHours)
            {
                throw new Exception($"The weekly hours of the total registered courses exceeds Maximum Weekly Hours: {MaxWeeklyHours}");
            }
            else
            {
                base.RegisterCourses(selectedCourses);
            }
        }

        public override string ToString()
        {
            return base.ToString() + " (Full time)";
        }
    }
}