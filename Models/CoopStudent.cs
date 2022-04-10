using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab8.Models;

namespace lab8.Models
{
    public class CoopStudent : Student
    {
        public static int MaxWeeklyHours { get; set; }
        public static int MaxNumOfCourses { get; set; }

        //Constructor
        public CoopStudent(string name) : base(name)
        {

        }

        //Method
        public override void RegisterCourses(List<Course> selectedCourses)
        {
            int totalWeeklyHours = TotalWeeklyHours(selectedCourses);
            int totalCourses = selectedCourses.Count;
            if (totalWeeklyHours > MaxWeeklyHours)
            {
                throw new Exception($"The weekly hours of the total registered courses exceeds Maximum Weekly Hours: {MaxWeeklyHours}");
            }
            else if (totalCourses > MaxNumOfCourses)
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
            return base.ToString() + " (Coop)";
        }
    }
}