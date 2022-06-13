namespace Lab_8VSRPP
{
    partial class MainForm
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
            this.BtnAddData = new System.Windows.Forms.Button();
            this.BtnCheckData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBtnPrepod = new System.Windows.Forms.RadioButton();
            this.RadioBtnStudent = new System.Windows.Forms.RadioButton();
            this.BtnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddData
            // 
            this.BtnAddData.Location = new System.Drawing.Point(254, 143);
            this.BtnAddData.Name = "BtnAddData";
            this.BtnAddData.Size = new System.Drawing.Size(193, 40);
            this.BtnAddData.TabIndex = 0;
            this.BtnAddData.Text = "Ввести данные";
            this.BtnAddData.UseVisualStyleBackColor = true;
            this.BtnAddData.Click += new System.EventHandler(this.BtnAddData_Click);
            // 
            // BtnCheckData
            // 
            this.BtnCheckData.Location = new System.Drawing.Point(254, 361);
            this.BtnCheckData.Name = "BtnCheckData";
            this.BtnCheckData.Size = new System.Drawing.Size(193, 40);
            this.BtnCheckData.TabIndex = 1;
            this.BtnCheckData.Text = "Просмотреть данные";
            this.BtnCheckData.UseVisualStyleBackColor = true;
            this.BtnCheckData.Click += new System.EventHandler(this.BtnCheckData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioBtnPrepod);
            this.groupBox1.Controls.Add(this.RadioBtnStudent);
            this.groupBox1.Location = new System.Drawing.Point(216, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите:";
            // 
            // RadioBtnPrepod
            // 
            this.RadioBtnPrepod.AutoSize = true;
            this.RadioBtnPrepod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnPrepod.Location = new System.Drawing.Point(31, 76);
            this.RadioBtnPrepod.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBtnPrepod.Name = "RadioBtnPrepod";
            this.RadioBtnPrepod.Size = new System.Drawing.Size(132, 20);
            this.RadioBtnPrepod.TabIndex = 1;
            this.RadioBtnPrepod.Text = "Преподаватель";
            this.RadioBtnPrepod.UseVisualStyleBackColor = true;
            // 
            // RadioBtnStudent
            // 
            this.RadioBtnStudent.AutoSize = true;
            this.RadioBtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnStudent.Location = new System.Drawing.Point(31, 37);
            this.RadioBtnStudent.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBtnStudent.Name = "RadioBtnStudent";
            this.RadioBtnStudent.Size = new System.Drawing.Size(83, 20);
            this.RadioBtnStudent.TabIndex = 0;
            this.RadioBtnStudent.Text = "Студент";
            this.RadioBtnStudent.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(254, 407);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(193, 40);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Выйти";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(87, 190);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(540, 164);
            this.listBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 454);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCheckData);
            this.Controls.Add(this.BtnAddData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddData;
        private System.Windows.Forms.Button BtnCheckData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBtnPrepod;
        private System.Windows.Forms.RadioButton RadioBtnStudent;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

