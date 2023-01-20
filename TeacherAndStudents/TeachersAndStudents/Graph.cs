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
    public partial class Graph : Form
    {
        public Graph(List<Teacher> teachers)
        {
            InitializeComponent();
            for (int i = 0; i < teachers.Count; i ++)
            {
                chart1.Series["Grade"].Points.AddXY(teachers[i].name, teachers[i].StudentsAverageGrade());
            }
        }
    }
}
