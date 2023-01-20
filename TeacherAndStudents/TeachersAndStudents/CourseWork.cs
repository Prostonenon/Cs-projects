using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersAndStudents
{
   public class CourseWork
    {
        public string printCourseWork()
        {
            return subject + ": " + date;
        }
        public string subject { get; set; }
        public string date { get; set; }
    }
}
