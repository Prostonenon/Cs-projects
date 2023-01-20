
namespace TeachersAndStudents
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Students");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.TeacherYOT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherFullAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherFullName = new System.Windows.Forms.Label();
            this.TreeViewStudents = new System.Windows.Forms.TreeView();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.ShowGraphButton = new System.Windows.Forms.Button();
            this.GridViewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.sendLettersButton = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.InfoPanel.Controls.Add(this.sendLettersButton);
            this.InfoPanel.Controls.Add(this.AddStudentButton);
            this.InfoPanel.Controls.Add(this.TeacherYOT);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.TeacherFullAge);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.TeacherFullName);
            this.InfoPanel.Controls.Add(this.TreeViewStudents);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPanel.Location = new System.Drawing.Point(277, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(523, 450);
            this.InfoPanel.TabIndex = 1;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentButton.Location = new System.Drawing.Point(13, 379);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(211, 28);
            this.AddStudentButton.TabIndex = 3;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // TeacherYOT
            // 
            this.TeacherYOT.AutoSize = true;
            this.TeacherYOT.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherYOT.Location = new System.Drawing.Point(338, 69);
            this.TeacherYOT.Name = "TeacherYOT";
            this.TeacherYOT.Size = new System.Drawing.Size(0, 29);
            this.TeacherYOT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Years of teaching:";
            // 
            // TeacherFullAge
            // 
            this.TeacherFullAge.AutoSize = true;
            this.TeacherFullAge.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherFullAge.Location = new System.Drawing.Point(75, 69);
            this.TeacherFullAge.Name = "TeacherFullAge";
            this.TeacherFullAge.Size = new System.Drawing.Size(0, 29);
            this.TeacherFullAge.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age:";
            // 
            // TeacherFullName
            // 
            this.TeacherFullName.AutoSize = true;
            this.TeacherFullName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherFullName.Location = new System.Drawing.Point(22, 12);
            this.TeacherFullName.Name = "TeacherFullName";
            this.TeacherFullName.Size = new System.Drawing.Size(0, 36);
            this.TeacherFullName.TabIndex = 3;
            // 
            // TreeViewStudents
            // 
            this.TreeViewStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.TreeViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeViewStudents.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeViewStudents.ItemHeight = 40;
            this.TreeViewStudents.Location = new System.Drawing.Point(7, 134);
            this.TreeViewStudents.Name = "TreeViewStudents";
            treeNode4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            treeNode4.Name = "NodeStudents";
            treeNode4.NodeFont = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "Students";
            this.TreeViewStudents.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.TreeViewStudents.Size = new System.Drawing.Size(484, 239);
            this.TreeViewStudents.TabIndex = 6;
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddTeacherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeacherButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeacherButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeacherButton.Location = new System.Drawing.Point(12, 12);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(121, 28);
            this.AddTeacherButton.TabIndex = 2;
            this.AddTeacherButton.Text = "Add Teacher";
            this.AddTeacherButton.UseVisualStyleBackColor = false;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // ShowGraphButton
            // 
            this.ShowGraphButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ShowGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowGraphButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowGraphButton.Location = new System.Drawing.Point(145, 12);
            this.ShowGraphButton.Name = "ShowGraphButton";
            this.ShowGraphButton.Size = new System.Drawing.Size(121, 28);
            this.ShowGraphButton.TabIndex = 3;
            this.ShowGraphButton.Text = "Show Graph";
            this.ShowGraphButton.UseVisualStyleBackColor = false;
            this.ShowGraphButton.Click += new System.EventHandler(this.ShowGraphButton_Click);
            // 
            // GridViewButton
            // 
            this.GridViewButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridViewButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridViewButton.Location = new System.Drawing.Point(12, 46);
            this.GridViewButton.Name = "GridViewButton";
            this.GridViewButton.Size = new System.Drawing.Size(121, 28);
            this.GridViewButton.TabIndex = 4;
            this.GridViewButton.Text = "Grid View";
            this.GridViewButton.UseVisualStyleBackColor = false;
            this.GridViewButton.Click += new System.EventHandler(this.GridViewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(144, 46);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 28);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(206, 46);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(60, 28);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // sendLettersButton
            // 
            this.sendLettersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.sendLettersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendLettersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendLettersButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendLettersButton.Location = new System.Drawing.Point(257, 379);
            this.sendLettersButton.Name = "sendLettersButton";
            this.sendLettersButton.Size = new System.Drawing.Size(211, 28);
            this.sendLettersButton.TabIndex = 17;
            this.sendLettersButton.Text = "Send Letters";
            this.sendLettersButton.UseVisualStyleBackColor = false;
            this.sendLettersButton.Click += new System.EventHandler(this.sendLettersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ShowGraphButton);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GridViewButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TreeView TreeViewStudents;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.Label TeacherYOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TeacherFullAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TeacherFullName;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button ShowGraphButton;
        private System.Windows.Forms.Button GridViewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button sendLettersButton;
    }
}

