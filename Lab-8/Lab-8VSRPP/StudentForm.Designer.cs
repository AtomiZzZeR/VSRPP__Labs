namespace Lab_8VSRPP
{
    partial class StudentForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.TextBoxCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSpeciality = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(112, 450);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(185, 32);
            this.BtnClose.TabIndex = 23;
            this.BtnClose.Text = "Назад";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Location = new System.Drawing.Point(112, 396);
            this.BtnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(185, 35);
            this.BtnAddStudent.TabIndex = 22;
            this.BtnAddStudent.Text = "Добавить";
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // TextBoxCourse
            // 
            this.TextBoxCourse.Location = new System.Drawing.Point(102, 355);
            this.TextBoxCourse.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCourse.Name = "TextBoxCourse";
            this.TextBoxCourse.Size = new System.Drawing.Size(208, 22);
            this.TextBoxCourse.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Курс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Специальность:";
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Location = new System.Drawing.Point(102, 225);
            this.ComboBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(208, 24);
            this.ComboBoxGender.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Пол:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(101, 41);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(208, 22);
            this.TextBoxName.TabIndex = 44;
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Location = new System.Drawing.Point(102, 170);
            this.TextBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(208, 22);
            this.TextBoxAge.TabIndex = 43;
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(102, 106);
            this.TextBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(208, 22);
            this.TextBoxSurname.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Возраст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Имя:";
            // 
            // TextBoxSpeciality
            // 
            this.TextBoxSpeciality.Location = new System.Drawing.Point(101, 287);
            this.TextBoxSpeciality.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSpeciality.Name = "TextBoxSpeciality";
            this.TextBoxSpeciality.Size = new System.Drawing.Size(208, 22);
            this.TextBoxSpeciality.TabIndex = 47;
            this.TextBoxSpeciality.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 495);
            this.Controls.Add(this.TextBoxSpeciality);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddStudent);
            this.Controls.Add(this.TextBoxCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.TextBox TextBoxCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxAge;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSpeciality;
    }
}