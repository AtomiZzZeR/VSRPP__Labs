namespace Lab_6
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
            System.Windows.Forms.ToolStripMenuItem преобразованияToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UpperCaseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.LowerCaseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.HowInFirstBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoMainTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeFontElem = new System.Windows.Forms.ToolStripComboBox();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeFontSizeElem = new System.Windows.Forms.ToolStripComboBox();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.CutBtn = new System.Windows.Forms.Button();
            this.DopTextBox = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonSearchSymbol = new System.Windows.Forms.Button();
            this.textBoxReadySearchSymbol = new System.Windows.Forms.TextBox();
            this.textBoxSearchSymbol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNextFind = new System.Windows.Forms.Button();
            this.BtnFirstFind = new System.Windows.Forms.Button();
            this.checkBoxRegister = new System.Windows.Forms.CheckBox();
            this.textBoxFindText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnChange = new System.Windows.Forms.Button();
            this.textBoxSome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxForChange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnForDeleteText = new System.Windows.Forms.Button();
            this.findNextBtn = new System.Windows.Forms.Button();
            this.findFirstBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxMain = new System.Windows.Forms.TabPage();
            this.BtnOption2 = new System.Windows.Forms.Button();
            this.BtnOption1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.OptionTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFont = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusChars = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            преобразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.DopTextBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TextBoxMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // преобразованияToolStripMenuItem
            // 
            преобразованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpperCaseBtn,
            this.LowerCaseBtn,
            this.HowInFirstBtn});
            преобразованияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("преобразованияToolStripMenuItem.Image")));
            преобразованияToolStripMenuItem.Name = "преобразованияToolStripMenuItem";
            преобразованияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            преобразованияToolStripMenuItem.Text = "Преобразования...";
            // 
            // UpperCaseBtn
            // 
            this.UpperCaseBtn.CheckOnClick = true;
            this.UpperCaseBtn.Name = "UpperCaseBtn";
            this.UpperCaseBtn.Size = new System.Drawing.Size(229, 26);
            this.UpperCaseBtn.Text = "Верхний регистр";
            this.UpperCaseBtn.Click += new System.EventHandler(this.UpperCaseBtn_Click);
            // 
            // LowerCaseBtn
            // 
            this.LowerCaseBtn.CheckOnClick = true;
            this.LowerCaseBtn.Name = "LowerCaseBtn";
            this.LowerCaseBtn.Size = new System.Drawing.Size(229, 26);
            this.LowerCaseBtn.Text = "Нижний регистр";
            this.LowerCaseBtn.Click += new System.EventHandler(this.LowerCaseBtn_Click);
            // 
            // HowInFirstBtn
            // 
            this.HowInFirstBtn.CheckOnClick = true;
            this.HowInFirstBtn.Name = "HowInFirstBtn";
            this.HowInFirstBtn.Size = new System.Drawing.Size(229, 26);
            this.HowInFirstBtn.Text = "Как в предложении";
            this.HowInFirstBtn.Click += new System.EventHandler(this.предложениеToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 335);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoMainTextBox,
            this.выйтмToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.менюToolStripMenuItem.Text = "Главная";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // gotoMainTextBox
            // 
            this.gotoMainTextBox.Image = ((System.Drawing.Image)(resources.GetObject("gotoMainTextBox.Image")));
            this.gotoMainTextBox.Name = "gotoMainTextBox";
            this.gotoMainTextBox.Size = new System.Drawing.Size(235, 26);
            this.gotoMainTextBox.Text = "Перейти на главную";
            this.gotoMainTextBox.Click += new System.EventHandler(this.gotoMainTextBox_Click);
            // 
            // выйтмToolStripMenuItem
            // 
            this.выйтмToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выйтмToolStripMenuItem.Image")));
            this.выйтмToolStripMenuItem.Name = "выйтмToolStripMenuItem";
            this.выйтмToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.выйтмToolStripMenuItem.Text = "Выйти";
            this.выйтмToolStripMenuItem.Click += new System.EventHandler(this.выйтмToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem1,
            this.размерToolStripMenuItem,
            преобразованияToolStripMenuItem});
            this.шрифтToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("шрифтToolStripMenuItem.Image")));
            this.шрифтToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.шрифтToolStripMenuItem.Text = "Инструменты";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem1
            // 
            this.шрифтToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeFontElem});
            this.шрифтToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("шрифтToolStripMenuItem1.Image")));
            this.шрифтToolStripMenuItem1.Name = "шрифтToolStripMenuItem1";
            this.шрифтToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.шрифтToolStripMenuItem1.Text = "Шрифт текста...";
            this.шрифтToolStripMenuItem1.Click += new System.EventHandler(this.шрифтToolStripMenuItem1_Click);
            // 
            // ChangeFontElem
            // 
            this.ChangeFontElem.Name = "ChangeFontElem";
            this.ChangeFontElem.Size = new System.Drawing.Size(140, 28);
            this.ChangeFontElem.Text = "Выбрать шрифт";
            this.ChangeFontElem.SelectedIndexChanged += new System.EventHandler(this.ChangeFontElem_SelectedIndexChanged);
            this.ChangeFontElem.Click += new System.EventHandler(this.ChangeFontElem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeFontSizeElem});
            this.размерToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("размерToolStripMenuItem.Image")));
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.размерToolStripMenuItem.Text = "Размер текста...";
            this.размерToolStripMenuItem.Click += new System.EventHandler(this.размерToolStripMenuItem_Click);
            // 
            // ChangeFontSizeElem
            // 
            this.ChangeFontSizeElem.Name = "ChangeFontSizeElem";
            this.ChangeFontSizeElem.Size = new System.Drawing.Size(140, 28);
            this.ChangeFontSizeElem.Text = "Выбрать размер";
            this.ChangeFontSizeElem.SelectedIndexChanged += new System.EventHandler(this.ChangeFontSizeElem_Enter);
            this.ChangeFontSizeElem.Click += new System.EventHandler(this.ChangeFontSizeElem_Click);
            this.ChangeFontSizeElem.EnabledChanged += new System.EventHandler(this.ChangeFontSizeElem_Enter);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("информацияToolStripMenuItem.Image")));
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(864, 145);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(254, 36);
            this.CopyBtn.TabIndex = 2;
            this.CopyBtn.Text = "Копировать";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(864, 38);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(254, 36);
            this.InsertBtn.TabIndex = 3;
            this.InsertBtn.Text = "Вставить";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // CutBtn
            // 
            this.CutBtn.Location = new System.Drawing.Point(864, 254);
            this.CutBtn.Name = "CutBtn";
            this.CutBtn.Size = new System.Drawing.Size(254, 36);
            this.CutBtn.TabIndex = 4;
            this.CutBtn.Text = "Вырезать";
            this.CutBtn.UseVisualStyleBackColor = true;
            this.CutBtn.Click += new System.EventHandler(this.CutBtn_Click);
            // 
            // DopTextBox
            // 
            this.DopTextBox.Controls.Add(this.tabPage3);
            this.DopTextBox.Controls.Add(this.tabPage4);
            this.DopTextBox.Controls.Add(this.tabPage1);
            this.DopTextBox.Controls.Add(this.tabPage2);
            this.DopTextBox.Controls.Add(this.TextBoxMain);
            this.DopTextBox.Location = new System.Drawing.Point(12, 44);
            this.DopTextBox.Name = "DopTextBox";
            this.DopTextBox.SelectedIndex = 0;
            this.DopTextBox.Size = new System.Drawing.Size(1161, 519);
            this.DopTextBox.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MainTextBox);
            this.tabPage3.Controls.Add(this.CutBtn);
            this.tabPage3.Controls.Add(this.CopyBtn);
            this.tabPage3.Controls.Add(this.InsertBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1153, 490);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Текст";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(21, 19);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainTextBox.Size = new System.Drawing.Size(815, 288);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.Text = "Введите текст...";
            this.MainTextBox.Click += new System.EventHandler(this.MainTextBox_Click);
            this.MainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            this.MainTextBox.Leave += new System.EventHandler(this.MainTextBox_Leave);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonSearchSymbol);
            this.tabPage4.Controls.Add(this.textBoxReadySearchSymbol);
            this.tabPage4.Controls.Add(this.textBoxSearchSymbol);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.BtnNextFind);
            this.tabPage4.Controls.Add(this.BtnFirstFind);
            this.tabPage4.Controls.Add(this.checkBoxRegister);
            this.tabPage4.Controls.Add(this.textBoxFindText);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.FindTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1153, 490);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Найти";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonSearchSymbol
            // 
            this.buttonSearchSymbol.Location = new System.Drawing.Point(781, 203);
            this.buttonSearchSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchSymbol.Name = "buttonSearchSymbol";
            this.buttonSearchSymbol.Size = new System.Drawing.Size(364, 28);
            this.buttonSearchSymbol.TabIndex = 15;
            this.buttonSearchSymbol.Text = "Искать";
            this.buttonSearchSymbol.UseVisualStyleBackColor = true;
            this.buttonSearchSymbol.Click += new System.EventHandler(this.buttonSearchSymbol_Click);
            // 
            // textBoxReadySearchSymbol
            // 
            this.textBoxReadySearchSymbol.Location = new System.Drawing.Point(787, 246);
            this.textBoxReadySearchSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadySearchSymbol.Multiline = true;
            this.textBoxReadySearchSymbol.Name = "textBoxReadySearchSymbol";
            this.textBoxReadySearchSymbol.ReadOnly = true;
            this.textBoxReadySearchSymbol.Size = new System.Drawing.Size(358, 62);
            this.textBoxReadySearchSymbol.TabIndex = 14;
            // 
            // textBoxSearchSymbol
            // 
            this.textBoxSearchSymbol.Location = new System.Drawing.Point(781, 173);
            this.textBoxSearchSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchSymbol.Name = "textBoxSearchSymbol";
            this.textBoxSearchSymbol.Size = new System.Drawing.Size(368, 22);
            this.textBoxSearchSymbol.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите символ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск вхождений символа";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnNextFind
            // 
            this.BtnNextFind.Enabled = false;
            this.BtnNextFind.Location = new System.Drawing.Point(903, 83);
            this.BtnNextFind.Name = "BtnNextFind";
            this.BtnNextFind.Size = new System.Drawing.Size(236, 23);
            this.BtnNextFind.TabIndex = 6;
            this.BtnNextFind.Text = "Найти следующее вхождение";
            this.BtnNextFind.UseVisualStyleBackColor = true;
            this.BtnNextFind.Click += new System.EventHandler(this.BtnNextFind_Click);
            // 
            // BtnFirstFind
            // 
            this.BtnFirstFind.Location = new System.Drawing.Point(781, 83);
            this.BtnFirstFind.Name = "BtnFirstFind";
            this.BtnFirstFind.Size = new System.Drawing.Size(103, 23);
            this.BtnFirstFind.TabIndex = 5;
            this.BtnFirstFind.Text = "Найти";
            this.BtnFirstFind.UseVisualStyleBackColor = true;
            this.BtnFirstFind.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxRegister
            // 
            this.checkBoxRegister.AutoSize = true;
            this.checkBoxRegister.Location = new System.Drawing.Point(781, 57);
            this.checkBoxRegister.Name = "checkBoxRegister";
            this.checkBoxRegister.Size = new System.Drawing.Size(152, 20);
            this.checkBoxRegister.TabIndex = 4;
            this.checkBoxRegister.Text = "С учётом регистра";
            this.checkBoxRegister.UseVisualStyleBackColor = true;
            // 
            // textBoxFindText
            // 
            this.textBoxFindText.Location = new System.Drawing.Point(781, 29);
            this.textBoxFindText.Name = "textBoxFindText";
            this.textBoxFindText.Size = new System.Drawing.Size(364, 22);
            this.textBoxFindText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите текст для поиска:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш текст:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(17, 29);
            this.FindTextBox.Multiline = true;
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.ReadOnly = true;
            this.FindTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FindTextBox.Size = new System.Drawing.Size(758, 279);
            this.FindTextBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnChange);
            this.tabPage1.Controls.Add(this.textBoxSome);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxForChange);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ChangeTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1153, 490);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Заменить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(866, 194);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(283, 30);
            this.BtnChange.TabIndex = 8;
            this.BtnChange.Text = "Применить";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxSome
            // 
            this.textBoxSome.Location = new System.Drawing.Point(866, 166);
            this.textBoxSome.Name = "textBoxSome";
            this.textBoxSome.Size = new System.Drawing.Size(283, 22);
            this.textBoxSome.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(868, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Заменить на:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxForChange
            // 
            this.textBoxForChange.Location = new System.Drawing.Point(866, 113);
            this.textBoxForChange.Name = "textBoxForChange";
            this.textBoxForChange.Size = new System.Drawing.Size(283, 22);
            this.textBoxForChange.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(868, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Введите текст для замены:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ваш текст:";
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Location = new System.Drawing.Point(18, 30);
            this.ChangeTextBox.Multiline = true;
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.ReadOnly = true;
            this.ChangeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChangeTextBox.Size = new System.Drawing.Size(842, 279);
            this.ChangeTextBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnForDeleteText);
            this.tabPage2.Controls.Add(this.findNextBtn);
            this.tabPage2.Controls.Add(this.findFirstBtn);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxDelete);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.DeleteTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1153, 490);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Удалить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnForDeleteText
            // 
            this.btnForDeleteText.Enabled = false;
            this.btnForDeleteText.Location = new System.Drawing.Point(840, 207);
            this.btnForDeleteText.Margin = new System.Windows.Forms.Padding(4);
            this.btnForDeleteText.Name = "btnForDeleteText";
            this.btnForDeleteText.Size = new System.Drawing.Size(304, 28);
            this.btnForDeleteText.TabIndex = 20;
            this.btnForDeleteText.Text = "Удалить текст";
            this.btnForDeleteText.UseVisualStyleBackColor = true;
            this.btnForDeleteText.Click += new System.EventHandler(this.buttonDelete);
            // 
            // findNextBtn
            // 
            this.findNextBtn.Enabled = false;
            this.findNextBtn.Location = new System.Drawing.Point(840, 171);
            this.findNextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.findNextBtn.Name = "findNextBtn";
            this.findNextBtn.Size = new System.Drawing.Size(304, 28);
            this.findNextBtn.TabIndex = 19;
            this.findNextBtn.Text = "Найти следующее вхождение";
            this.findNextBtn.UseVisualStyleBackColor = true;
            this.findNextBtn.Click += new System.EventHandler(this.FindNextBtn_Click);
            // 
            // findFirstBtn
            // 
            this.findFirstBtn.Location = new System.Drawing.Point(840, 135);
            this.findFirstBtn.Margin = new System.Windows.Forms.Padding(4);
            this.findFirstBtn.Name = "findFirstBtn";
            this.findFirstBtn.Size = new System.Drawing.Size(304, 28);
            this.findFirstBtn.TabIndex = 18;
            this.findFirstBtn.Text = "Найти первое вхождение";
            this.findFirstBtn.UseVisualStyleBackColor = true;
            this.findFirstBtn.Click += new System.EventHandler(this.findFirstBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(901, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Введите удаляемый текст:";
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(840, 106);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(304, 22);
            this.textBoxDelete.TabIndex = 6;
            this.textBoxDelete.TextChanged += new System.EventHandler(this.textBoxDeleting);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ваш текст:";
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(19, 29);
            this.DeleteTextBox.Multiline = true;
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.ReadOnly = true;
            this.DeleteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DeleteTextBox.Size = new System.Drawing.Size(814, 279);
            this.DeleteTextBox.TabIndex = 4;
            // 
            // TextBoxMain
            // 
            this.TextBoxMain.Controls.Add(this.BtnOption2);
            this.TextBoxMain.Controls.Add(this.BtnOption1);
            this.TextBoxMain.Controls.Add(this.label10);
            this.TextBoxMain.Controls.Add(this.OptionTextBox);
            this.TextBoxMain.Location = new System.Drawing.Point(4, 25);
            this.TextBoxMain.Name = "TextBoxMain";
            this.TextBoxMain.Size = new System.Drawing.Size(1153, 490);
            this.TextBoxMain.TabIndex = 4;
            this.TextBoxMain.Text = "Доп...";
            this.TextBoxMain.UseVisualStyleBackColor = true;
            // 
            // BtnOption2
            // 
            this.BtnOption2.Location = new System.Drawing.Point(860, 197);
            this.BtnOption2.Name = "BtnOption2";
            this.BtnOption2.Size = new System.Drawing.Size(290, 66);
            this.BtnOption2.TabIndex = 12;
            this.BtnOption2.Text = "б) Переписать каждое предложение, расположив слова в алфавитном порядке.";
            this.BtnOption2.UseVisualStyleBackColor = true;
            this.BtnOption2.Click += new System.EventHandler(this.button10_Click);
            // 
            // BtnOption1
            // 
            this.BtnOption1.Location = new System.Drawing.Point(860, 64);
            this.BtnOption1.Name = "BtnOption1";
            this.BtnOption1.Size = new System.Drawing.Size(290, 66);
            this.BtnOption1.TabIndex = 10;
            this.BtnOption1.Text = "а) Подсчитать количество слов в данной строке длиной в пять символов.";
            this.BtnOption1.UseVisualStyleBackColor = true;
            this.BtnOption1.Click += new System.EventHandler(this.BtnOption1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ваш текст:";
            // 
            // OptionTextBox
            // 
            this.OptionTextBox.Location = new System.Drawing.Point(15, 28);
            this.OptionTextBox.Multiline = true;
            this.OptionTextBox.Name = "OptionTextBox";
            this.OptionTextBox.ReadOnly = true;
            this.OptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OptionTextBox.Size = new System.Drawing.Size(839, 279);
            this.OptionTextBox.TabIndex = 6;
            this.OptionTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDate,
            this.toolStripStatusFont,
            this.toolStripStatusChars});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1185, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusDate
            // 
            this.toolStripStatusDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusDate.Name = "toolStripStatusDate";
            this.toolStripStatusDate.Size = new System.Drawing.Size(390, 20);
            this.toolStripStatusDate.Spring = true;
            this.toolStripStatusDate.Text = "[Дата]";
            this.toolStripStatusDate.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusFont
            // 
            this.toolStripStatusFont.Name = "toolStripStatusFont";
            this.toolStripStatusFont.Size = new System.Drawing.Size(390, 20);
            this.toolStripStatusFont.Spring = true;
            this.toolStripStatusFont.Text = "[Шрифт]";
            // 
            // toolStripStatusChars
            // 
            this.toolStripStatusChars.Name = "toolStripStatusChars";
            this.toolStripStatusChars.Size = new System.Drawing.Size(390, 20);
            this.toolStripStatusChars.Spring = true;
            this.toolStripStatusChars.Text = "[Символов в строке]";
            this.toolStripStatusChars.Click += new System.EventHandler(this.toolStripStatusChars_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 418);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DopTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab-6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DopTextBox.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TextBoxMain.ResumeLayout(false);
            this.TextBoxMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoMainTextBox;
        private System.Windows.Forms.ToolStripMenuItem выйтмToolStripMenuItem;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button CutBtn;
        private System.Windows.Forms.TabControl DopTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TextBoxMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFont;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusChars;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.ToolStripMenuItem UpperCaseBtn;
        private System.Windows.Forms.ToolStripMenuItem LowerCaseBtn;
        private System.Windows.Forms.ToolStripMenuItem HowInFirstBtn;
        private System.Windows.Forms.ToolStripComboBox ChangeFontElem;
        private System.Windows.Forms.ToolStripComboBox ChangeFontSizeElem;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNextFind;
        private System.Windows.Forms.Button BtnFirstFind;
        private System.Windows.Forms.CheckBox checkBoxRegister;
        private System.Windows.Forms.TextBox textBoxFindText;
        private System.Windows.Forms.Button buttonSearchSymbol;
        private System.Windows.Forms.TextBox textBoxReadySearchSymbol;
        private System.Windows.Forms.TextBox textBoxSearchSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.TextBox textBoxSome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxForChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.Button findFirstBtn;
        private System.Windows.Forms.Button btnForDeleteText;
        private System.Windows.Forms.Button findNextBtn;
        private System.Windows.Forms.Button BtnOption2;
        private System.Windows.Forms.Button BtnOption1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OptionTextBox;
    }
}

