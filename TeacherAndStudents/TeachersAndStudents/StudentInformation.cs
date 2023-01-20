using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace TeachersAndStudents
{
    public partial class StudentInformation : Form
    {
        string email { get; set; }

        Form1 mainForm = new Form1();

        List<CourseWork> overdueCourseWorks = new List<CourseWork>();

        Student student = new Student();

        int selectedTeacher { get; set; }
        public StudentInformation(Student _student, Form1 _mainForm)
        {
            InitializeComponent();
            studentName.Text = _student.fullName;
            studentAge.Text = _student.age.ToString();
            studentCourse.Text = _student.course.ToString();
            studentGrade.Text = _student.grade.ToString();
            studentEmail.Text = _student.email;
            email = _student.email;
            mainForm = _mainForm;
            student = _student;
            selectedTeacher = mainForm.selectedTeacher;
            for(int i = 0; i < _student.courseWorks.Count; i++)
            {
                courseWorks.Nodes[0].Nodes.Add(new TreeNode(_student.courseWorks[i].subject + ": " + _student.courseWorks[i].date));
                if (DateTime.Now > DateTime.Parse(_student.courseWorks[i].date))
                {
                    courseWorks.Nodes[0].Nodes[i].ForeColor = Color.Red;
                    overdueCourseWorks.Add(_student.courseWorks[i]);
                }
            }
        }

        private void sendLetter_Click(object sender, EventArgs e)
        {
            if(overdueCourseWorks.Count > 0)
            {
                for(int i = 0; i < overdueCourseWorks.Count; i++) 
                {
                    mainForm.SendLetter(student, overdueCourseWorks[i]); 
                }
             
            }
            else { MessageBox.Show("This student doesn't have unfinished course works"); }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            mainForm.DeleteStudent(student, mainForm.teachers[selectedTeacher]);
        }
    }
}
