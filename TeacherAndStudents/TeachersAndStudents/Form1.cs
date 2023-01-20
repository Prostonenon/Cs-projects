using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Mail;

namespace TeachersAndStudents
{
    public partial class Form1 : Form
    {
        public List<Teacher> teachers { get; set; }
        public Point currentPosition = new Point(9, 92);
        public int selectedTeacher { get; set; }

        public List<Panel> panels = new List<Panel>();

        void LoadData(string path)
        {
            StreamReader r = new StreamReader(path);
            string json = r.ReadToEnd();
            teachers = JsonSerializer.Deserialize<List<Teacher>>(json);
            selectedTeacher = 0;
            CreateManyPanels();
            Select(false, false);
            TreeViewStudents.NodeMouseClick += new TreeNodeMouseClickEventHandler(TreeViewStudents_MouseClick);
            TreeViewStudents.NodeMouseHover += new TreeNodeMouseHoverEventHandler(TreeViewStudents_Hover);
            TreeViewStudents.MouseLeave += (s, e) =>
            {
                Cursor = Cursors.Default;
            };
            
            this.Closed += new EventHandler(formClose);
        }
        public void CreateOnePanel(Teacher teacher)
        {
            Panel panel = new Panel();
            panel.Name = teachers.IndexOf(teacher).ToString();
            Controls.Add(panel);
            panel.Location = currentPosition;
            currentPosition.Y += 75;
            panel.Size = new Size(249, 55);
            panel.BackColor = Color.FromArgb(70, 90, 172);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Click += new EventHandler(Teacher_Selected);
            panel.MouseEnter += new EventHandler(Teacher_MouseEnter);
            panel.MouseLeave += new EventHandler(Teacher_MouseOut);
            

            Label name = new Label();
            name.Visible = true;
            name.Show();
            name.Parent = panel;
            name.ForeColor = Color.White;
            name.Location = new Point(61, 16);
            name.AutoSize = true;
            name.Font = new Font("Times New Roman", 14);
            name.Text = teacher.name + ", " + teacher.age;
            name.Click += new EventHandler(Panel_Clicked);
            name.MouseEnter += new EventHandler(Panel_MouseEnter);

            PictureBox teacherPicture = new PictureBox();
            teacherPicture.Visible = true;
            teacherPicture.Show();
            teacherPicture.BackColor = Color.White;
            teacherPicture.Parent = panel;
            teacherPicture.Location = new Point(-2, -2);
            teacherPicture.Size = new Size(53, 55);
            teacherPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            teacherPicture.ImageLocation = Directory.GetCurrentDirectory().Replace("bin\\Debug", "") + "teacher-11.png";
            teacherPicture.Click += new EventHandler(Panel_Clicked);
            teacherPicture.MouseEnter += new EventHandler(Panel_MouseEnter);
            teacherPicture.MouseLeave += new EventHandler(Panel_MouseLeave);

            Button deleteTeacherButton = new Button();
            deleteTeacherButton.Visible = true;
            deleteTeacherButton.Show();
            deleteTeacherButton.Parent = panel;
            deleteTeacherButton.Text = "X";
            deleteTeacherButton.FlatStyle = FlatStyle.Flat;
            deleteTeacherButton.Size = new Size(32, 32);
            deleteTeacherButton.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            deleteTeacherButton.Location = new Point(210, 10);
            deleteTeacherButton.BackColor = Color.FromArgb(227, 54, 54);
            deleteTeacherButton.Click += new EventHandler(DeleteTeacherButton_Click);
            deleteTeacherButton.MouseEnter += new EventHandler(Panel_MouseEnter);

            if (teachers.IndexOf(teacher) == 0)
            {
                Teacher_Selected(panel, EventArgs.Empty);
            }

            void Panel_Clicked(object sender, EventArgs e)
            {
                Teacher_Selected(panel, e);
            }

            void Panel_MouseEnter(object sender, EventArgs e)
            {
                Teacher_MouseEnter(panel, e);
            }

            void Panel_MouseLeave(object sender, EventArgs e)
            {
                Teacher_MouseOut(panel, e);
            }

            panels.Add(panel);
        }

        void CreateManyPanels()
        {
            for(int i = 0; i < teachers.Count(); i++)
            {
                CreateOnePanel(teachers[i]);
            }
            
        }

        private void formClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AddStudentNode(int selectedTeacher, int nodeNumber)
        {
            TreeNode node = new TreeNode(teachers[selectedTeacher].students[nodeNumber].name);
            TreeViewStudents.Nodes[0].Nodes.Add(node);
            TreeViewStudents.Nodes[0].Nodes[nodeNumber].Name = "studentNode" + nodeNumber.ToString();
            TreeNode viewNode = new TreeNode("More info about student");
            TreeViewStudents.Nodes[0].Nodes[nodeNumber].Nodes.Add(viewNode);
            TreeViewStudents.Nodes[0].Nodes[nodeNumber].Nodes[0].ForeColor = Color.Blue;
            
            for (int j = 0; j < teachers[selectedTeacher].students[nodeNumber].courseWorks.Count; j++)
            {
                CourseWork courseWork = teachers[selectedTeacher].students[nodeNumber].courseWorks[j];
                TreeNode courseNode = new TreeNode(courseWork.printCourseWork());
                TreeViewStudents.Nodes[0].Nodes[nodeNumber].Nodes.Add(courseNode);
                if (DateTime.Now > DateTime.Parse(courseWork.date))
                {
                    TreeViewStudents.Nodes[0].Nodes[nodeNumber].Nodes[j + 1].ForeColor = Color.Red;
                }
            }
        }


        private void Teacher_Selected(object sender, EventArgs e)
        {
            Select(false, false);
            Panel panel = (sender as Panel);
            selectedTeacher = Int32.Parse(panel.Name);
            TeacherFullName.Text = teachers[selectedTeacher].fullName + ":";
            TeacherFullAge.Text = teachers[selectedTeacher].age.ToString();
            TeacherYOT.Text = teachers[selectedTeacher].yearsOfTeaching.ToString();

            TreeViewStudents.Nodes[0].Nodes.Clear();
           for (int i = 0; i < teachers[selectedTeacher].students.Count; i++)
           {
                AddStudentNode(selectedTeacher, i);
           }
            TreeViewStudents.CollapseAll();
        }

        public void DeleteStudent(Student student, Teacher studentTeacher)
        {
            studentTeacher.students.Remove(student);
            TreeViewStudents.Nodes[0].Nodes.Clear();
            for (int i = 0; i < teachers[selectedTeacher].students.Count; i++)
            {
                AddStudentNode(selectedTeacher, i);
            }
        }

        public Form1()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory() + "\\Data.json";
            LoadData(path);
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
        }

        public Form1(string path)
        {
            InitializeComponent();
            LoadData(path);
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
        }

        private void Teacher_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (sender as Panel);
            panel.BackColor = Color.FromArgb(56, 73, 140);
            this.Cursor = Cursors.Hand;
        }

        private void Teacher_MouseOut(object sender, EventArgs e)
        {
            Panel panel = (sender as Panel);
            panel.BackColor = Color.FromArgb(70, 90, 172);
            this.Cursor = Cursors.Default;
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            TeacherConstruct addTeacher = new TeacherConstruct(this);
            addTeacher.TopMost = true;
            addTeacher.Show();

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            StudentConstruct studentConstruct = new StudentConstruct(this, selectedTeacher);
            studentConstruct.TopMost = true;
            studentConstruct.Show();
        }

        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            if(panels.Count > 1)
            {
                Button button = (sender as Button);
                Panel panel = (button.Parent as Panel);
                int panelNumber = Int32.Parse(panel.Name);
                this.Controls.Remove(panel);
                panels.Remove(panel);
                teachers.Remove(teachers[panelNumber]);
                for (int i = 0; i < panels.Count; i++)
                { 
                    if (Int32.Parse(panels[i].Name) >= panelNumber)
                    {
                        panels[i].Name = i.ToString();
                        if(panels[i].Location.Y >= 172) 
                        {
                            panels[i].Location = new Point(panels[i].Location.X, panels[i].Location.Y - 75);
                        }
                        else
                        {
                            panels[i].Location = new Point(panels[i].Location.X, 92);
                        }
                        
                    }

                }
                currentPosition = new Point(9, 92);
            }
        }

        private void TreeViewStudents_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "More info about student")
            {
                 int selectedStudentNumber = Int32.Parse(e.Node.Parent.Name.Replace("studentNode", ""));
                 Student selectedStudent = teachers[selectedTeacher].students[selectedStudentNumber];
                 StudentInformation studentInformation = new StudentInformation(selectedStudent, this);
                 studentInformation.TopMost = true;
                 studentInformation.Show();   
            }
        }

        private void TreeViewStudents_Hover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            bool isNewCursorAssigned = false;
            if (e.Node.Parent != null)
            {
                if (e.Node.Text == "More info about student")
                {
                    this.Cursor = Cursors.Hand;
                    isNewCursorAssigned = true;
                }
            }
            if (isNewCursorAssigned == false && this.Cursor != this.DefaultCursor)
                this.Cursor = this.DefaultCursor;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "json files (*.json)|*.json";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                /*var panels = this.Controls.OfType<Panel>().ToArray();
                currentPosition = new Point(9, 78);
                TreeViewStudents.Nodes[0].Nodes.Clear();
                foreach (var panel in panels)
                {
                    if(panel.Name.Contains("panel"))
                    this.Controls.Remove(panel);
                }
                teachers.Clear();
                LoadData(path);*/
                Form1 newForm = new Form1(path);
                newForm.Show();
                this.Hide();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(teachers);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\";      
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = "Text files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(path);
                sw.Write(jsonString);
            }
        }

        private void GridViewButton_Click(object sender, EventArgs e)
        {
            GridViewForm gridView = new GridViewForm(teachers);
            gridView.TopMost = true;
            gridView.Show();
        }

        private void ShowGraphButton_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(teachers);
            graph.TopLevel = true;
            graph.Show();
        }

        public void SendLetter(Student student, CourseWork overduecourseWork)
        {
            string email = student.email;
            if(email != null && email.Contains('@'))
            {
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("examexample24@gmail.com", "Your university");
                mail.To.Add(email);
                mail.Subject = "Don't forget about your unfinished course work!";
                mail.IsBodyHtml = true;
                mail.Body = $"<h1>You were supposed to turn in your {overduecourseWork.subject}" +
                    $" on {overduecourseWork.date}</h1>";
                client.EnableSsl = true;
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("examexample24@gmail.com", "dgmeryvsztwldhvt");
                client.Send(mail);
            }
            else
            {
                MessageBox.Show("This student doesn't have an email address!");
            }
        }

        private void sendLettersButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < teachers[selectedTeacher].students.Count; i++)
            {
                Student student = teachers[selectedTeacher].students[i];
                for(int j = 0; j < student.courseWorks.Count; j ++)
                {
                    if(DateTime.Parse(student.courseWorks[j].date) < DateTime.Now)
                    {
                        SendLetter(student, student.courseWorks[j]);
                    }
                }
            }
        }
    }
}
