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
    public partial class GridViewForm : Form
    {
        List<Teacher> teachers = new List<Teacher>();
        public GridViewForm(List<Teacher> _teachers)
        {
            InitializeComponent();
            teachers = _teachers;
            for(int i = 0; i < teachers.Count; i++)
            {
                dataGridView1.Rows.Add(teachers[i].name, teachers[i].age.ToString(), teachers[i].yearsOfTeaching.ToString(),
                    teachers[i].students.Count.ToString(), teachers[i].StudentsAverageGrade().ToString());
            }
        }

    }
}
