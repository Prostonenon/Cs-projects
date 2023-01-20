
namespace TeachersAndStudents
{
    partial class TeacherConstruct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newTeacherName = new System.Windows.Forms.TextBox();
            this.newTeacherAge = new System.Windows.Forms.TextBox();
            this.newTeacherYot = new System.Windows.Forms.TextBox();
            this.SetTeacherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Years of teaching:";
            // 
            // newTeacherName
            // 
            this.newTeacherName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTeacherName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTeacherName.Location = new System.Drawing.Point(126, 9);
            this.newTeacherName.MinimumSize = new System.Drawing.Size(160, 25);
            this.newTeacherName.Name = "newTeacherName";
            this.newTeacherName.Size = new System.Drawing.Size(182, 26);
            this.newTeacherName.TabIndex = 3;
            // 
            // newTeacherAge
            // 
            this.newTeacherAge.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newTeacherAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTeacherAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTeacherAge.Location = new System.Drawing.Point(66, 54);
            this.newTeacherAge.MinimumSize = new System.Drawing.Size(40, 25);
            this.newTeacherAge.Name = "newTeacherAge";
            this.newTeacherAge.Size = new System.Drawing.Size(64, 26);
            this.newTeacherAge.TabIndex = 4;
            // 
            // newTeacherYot
            // 
            this.newTeacherYot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newTeacherYot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTeacherYot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTeacherYot.Location = new System.Drawing.Point(196, 101);
            this.newTeacherYot.Name = "newTeacherYot";
            this.newTeacherYot.Size = new System.Drawing.Size(64, 26);
            this.newTeacherYot.TabIndex = 5;
            // 
            // SetTeacherButton
            // 
            this.SetTeacherButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SetTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTeacherButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetTeacherButton.Location = new System.Drawing.Point(84, 161);
            this.SetTeacherButton.Name = "SetTeacherButton";
            this.SetTeacherButton.Size = new System.Drawing.Size(149, 40);
            this.SetTeacherButton.TabIndex = 8;
            this.SetTeacherButton.Text = "Add Teacher";
            this.SetTeacherButton.UseVisualStyleBackColor = false;
            this.SetTeacherButton.Click += new System.EventHandler(this.SetTeacherButton_Click);
            // 
            // TeacherConstruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 220);
            this.Controls.Add(this.SetTeacherButton);
            this.Controls.Add(this.newTeacherYot);
            this.Controls.Add(this.newTeacherAge);
            this.Controls.Add(this.newTeacherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherConstruct";
            this.Text = "AddTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newTeacherName;
        private System.Windows.Forms.TextBox newTeacherAge;
        private System.Windows.Forms.TextBox newTeacherYot;
        private System.Windows.Forms.Button SetTeacherButton;
    }
}