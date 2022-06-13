namespace Lab_7
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
            this.btnEnterData = new System.Windows.Forms.Button();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(110, 32);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(183, 38);
            this.btnEnterData.TabIndex = 0;
            this.btnEnterData.Text = "Ввести данные";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(110, 90);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(183, 38);
            this.btnViewData.TabIndex = 1;
            this.btnViewData.Text = "Просмотреть данные";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.BtnViewData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(110, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 211);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.btnEnterData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterData;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnExit;
    }
}

