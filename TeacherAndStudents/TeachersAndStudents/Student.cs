using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersAndStudents
{
   public class Student
    {
       public string name { get; set; }
       public string fullName { get; set; }
       public string email { get; set; }
       public int age { get; set; }
       public int course { get; set; }
       public List<CourseWork> courseWorks { get; set; }
       public int grade { get; set; }
    }
}
