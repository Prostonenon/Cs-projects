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
    public partial class TeacherConstruct : Form
    {
        Form1 mainForm = new Form1();
        
        public TeacherConstruct(object _mainForm)
        {
            InitializeComponent();
            mainForm = (_mainForm as Form1);
        }


        private void SetTeacherButton_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.fullName = newTeacherName.Text;
            try
            {
                teacher.age = Int32.Parse(newTeacherAge.Text);
                teacher.yearsOfTeaching = Int32.Parse(newTeacherYot.Text);
            }
            catch(Exception)
            {}
            
            string[] words = newTeacherName.Text.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                if(i != words.Length - 1)
                {
                    words[i] = words[i][0] + ".";
                }
                teacher.name += words[i];
            }
            List<Student> students = new List<Student>();
            teacher.students = students;
            mainForm.teachers.Add(teacher);
            mainForm.CreateOnePanel(teacher);
            this.Close();
        }
    }
}
