using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersAndStudents
{
    public class Teacher
    {
        public int StudentsAverageGrade()
        {
            int result = 0;
            if(students.Count > 0)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    result += students[i].grade;
                }
                return result / students.Count;
            }
            else { return 0;  }
        }
        public string name { get; set; }
        public string fullName { get; set; }
        public int age { get; set; }
        public int yearsOfTeaching { get; set; }
        public List<Student> students { get; set; }
    }
}
