using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachersAndStudents
{
    public partial class StudentConstruct : Form
    {
        Form1 mainForm = new Form1();
        int selectedTeacher = 0;
        public StudentConstruct(object _mainForm, int _selectedTeacher)
        {
            InitializeComponent();
            mainForm = (_mainForm as Form1);
            selectedTeacher = _selectedTeacher;
        }

        private void SetStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.fullName = newStudentName.Text;
            try
            {
                student.age = Int32.Parse(newStudentAge.Text);
                student.course = Int32.Parse(newStudentCourse.Text);
                student.grade = Int32.Parse(NewStudentGrade.Text);
            }
            catch
            { }
            student.email = newStudentEmail.Text;
            string[] words = newStudentName.Text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (i != words.Length - 1)
                {
                    words[i] = words[i][0] + ".";
                }
                student.name += words[i] + " ";
            }
            List<CourseWork> courseWorks = new List<CourseWork>();
            student.courseWorks = courseWorks;
            mainForm.teachers[selectedTeacher].students.Add(student);
            TreeNode node = new TreeNode(student.name);
            mainForm.AddStudentNode(selectedTeacher, mainForm.teachers[selectedTeacher].students.Count - 1);
            this.Close();
        }
    }
}
