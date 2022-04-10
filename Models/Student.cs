using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab8.Models;

namespace lab8.Models
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }

        public List<Course> RegisteredCourses { get; }

        //Constructor
        public Student(string name)
        {
            Name = name;
            Random rand = new Random();
            Id = rand.Next(100000, 1000000);
            RegisteredCourses = new List<Course>();
        }

        //Method
        public virtual void RegisterCourses(List<Course> selectedCourses)
        {
            RegisteredCourses.Clear();
            foreach (Course course in selectedCourses)
            {
                RegisteredCourses.Add(course);
            }
        }

        public int TotalWeeklyHours(List<Course> selectedCourses)
        {
            int hours = 0;
            foreach (Course c in selectedCourses)
            {
                hours += c.WeeklyHours;
            }
            return hours;
        }

        public override string ToString()
        {
            return string.Format($"{Id} - {Name}");
        }
    }
}