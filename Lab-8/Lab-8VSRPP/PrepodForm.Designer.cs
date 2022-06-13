namespace Lab_8VSRPP
{
    partial class PrepodForm
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
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddPrepod = new System.Windows.Forms.Button();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.TextBoxStaj = new System.Windows.Forms.TextBox();
            this.ComboBoxPost = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(106, 43);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(208, 22);
            this.TextBoxName.TabIndex = 36;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(117, 451);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(185, 32);
            this.BtnClose.TabIndex = 35;
            this.BtnClose.Text = "Назад";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddPrepod
            // 
            this.BtnAddPrepod.Location = new System.Drawing.Point(117, 397);
            this.BtnAddPrepod.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddPrepod.Name = "BtnAddPrepod";
            this.BtnAddPrepod.Size = new System.Drawing.Size(185, 35);
            this.BtnAddPrepod.TabIndex = 34;
            this.BtnAddPrepod.Text = "Добавить";
            this.BtnAddPrepod.UseVisualStyleBackColor = true;
            this.BtnAddPrepod.Click += new System.EventHandler(this.BtnAddPrepod_Click);
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Location = new System.Drawing.Point(107, 172);
            this.TextBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(208, 22);
            this.TextBoxAge.TabIndex = 33;
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(107, 108);
            this.TextBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(208, 22);
            this.TextBoxSurname.TabIndex = 32;
            // 
            // TextBoxStaj
            // 
            this.TextBoxStaj.Location = new System.Drawing.Point(107, 356);
            this.TextBoxStaj.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxStaj.Name = "TextBoxStaj";
            this.TextBoxStaj.Size = new System.Drawing.Size(208, 22);
            this.TextBoxStaj.TabIndex = 31;
            // 
            // ComboBoxPost
            // 
            this.ComboBoxPost.FormattingEnabled = true;
            this.ComboBoxPost.Location = new System.Drawing.Point(107, 288);
            this.ComboBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxPost.Name = "ComboBoxPost";
            this.ComboBoxPost.Size = new System.Drawing.Size(208, 24);
            this.ComboBoxPost.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Стаж:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Возраст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя:";
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Location = new System.Drawing.Point(107, 227);
            this.ComboBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(208, 24);
            this.ComboBoxGender.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Пол:";
            // 
            // PrepodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 491);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddPrepod);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxStaj);
            this.Controls.Add(this.ComboBoxPost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrepodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrepodForm";
            this.Load += new System.EventHandler(this.PrepodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddPrepod;
        private System.Windows.Forms.TextBox TextBoxAge;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.TextBox TextBoxStaj;
        private System.Windows.Forms.ComboBox ComboBoxPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.Label label6;
    }
}