using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        private int checkClickTextBox = 0;
        private readonly string date = DateTime.Now.ToString();
        public Form1()
        {
            InitializeComponent();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                ChangeFontElem.ComboBox.Items.Add(font.Name);
            }

            for (int i = 0; i < 100; i++)
            {
                ChangeFontSizeElem.ComboBox.Items.Add(i + 1);
            }

            int counterCharsNum = 0;
            string counterCharsString = counterCharsNum.ToString();

            string currentFont = MainTextBox.Font.Name.ToString();

            //toolStripStatusDate.Text = date;
            toolStripStatusFont.Text = currentFont;
            toolStripStatusChars.Text = "Символов в строке: " + counterCharsString;
        }

        private void выйтмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Лабораторную работу №6\nвыполнил студент Дювбанов В.В.\n\tВариант 2", "Информация:");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString();
            toolStripStatusDate.Text = date;
        }

        private void MainTextBox_Click(object sender, EventArgs e)
        {
            if (checkClickTextBox == 0)
            {
                MainTextBox.Clear();
                checkClickTextBox++;
            }
        }

        private void gotoMainTextBox_Click(object sender, EventArgs e)
        {
            DopTextBox.SelectedTab = tabPage3;
        }

        private void MainTextBox_Leave(object sender, EventArgs e)
        {
            int QuantityOfCharsLeave = MainTextBox.Text.Length;

            if (QuantityOfCharsLeave != 0)
            {
                string textFromMainTextBox = MainTextBox.Text.ToString();

                FindTextBox.Text = textFromMainTextBox;
                ChangeTextBox.Text = textFromMainTextBox;
                DeleteTextBox.Text = textFromMainTextBox;
                OptionTextBox.Text = textFromMainTextBox;
            } else
            {
                MainTextBox.Text = "Введите текст...";
                FindTextBox.Text = "";
                ChangeTextBox.Text = "";
                DeleteTextBox.Text = "";
                OptionTextBox.Text = "";

                checkClickTextBox--;
            }
        }

        // CopyBtn
        private void button1_Click(object sender, EventArgs e)
        {
            if (MainTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(MainTextBox.SelectedText, true);
            }
            else
            {
                MessageBox.Show("Не выделен текст для копирования!", "Ошибка:");
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (checkClickTextBox == 0)
            {
                MainTextBox.Clear();
                checkClickTextBox++;
            }

            string textInsert = Clipboard.GetText();
            int selectIndex = MainTextBox.SelectionStart;
            bool selection = MainTextBox.SelectionLength > 0;
            string resultText;

            if (selection)
            {
                resultText = MainTextBox.Text.Remove(selectIndex, MainTextBox.SelectionLength);
            }
            else
            {
                resultText = MainTextBox.Text;
            }

            MainTextBox.Text = resultText.Insert(selectIndex, textInsert);

            if (selection)
            {
                MainTextBox.SelectionStart = selectIndex;
                MainTextBox.SelectionLength = resultText.Length;
            }
        }

        private void CutBtn_Click(object sender, EventArgs e)
        {
            if (MainTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(MainTextBox.SelectedText, true);
                MainTextBox.SelectedText = "";
            }
            else
            {
                MessageBox.Show("Не выделен текст!", "Ошибка:");
            }
        }

        private void buttonDelete(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "Введите текст..." || MainTextBox.Text != "" || MainTextBox.Text != " ")
            {
                string deleteText = textBoxDelete.Text;

                int strLength = deleteText.Length;
                int index = DeleteTextBox.SelectionStart;

                string resultStr = MainTextBox.Text.Remove(index, strLength);

                MainTextBox.Text = resultStr;
            }

            btnForDeleteText.Enabled = false;
        }

        private void findFirstBtn_Click(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "Введите текст...")
            {
                string deleteText = textBoxDelete.Text;

                int strLength = deleteText.Length;
                int index = MainTextBox.Text.IndexOf(deleteText);

                if (index != -1)
                {
                    DeleteTextBox.Focus();
                    DeleteTextBox.SelectionStart = index;
                    DeleteTextBox.SelectionLength = strLength;
                    findNextBtn.Enabled = true;
                    btnForDeleteText.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Не обнаружено вхождений!", "Ошибка");
                }
            }
        }

        private void FindNextBtn_Click(object sender, EventArgs e)
        {
            string deleteText = textBoxDelete.Text;

            int strLength = deleteText.Length;
            int index = DeleteTextBox.SelectionStart + strLength;
            DeleteTextBox.Focus();
            int newIndex = MainTextBox.Text.IndexOf(deleteText, index);

            if (newIndex != -1)
            {
                DeleteTextBox.SelectionStart = newIndex;
                DeleteTextBox.SelectionLength = strLength;
            }
            else
            {
                findNextBtn.Enabled = false;
                btnForDeleteText.Enabled = false;
                MessageBox.Show("Пройдены все вхождения!", "Ошибка");
            }
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HowInFirstBtn.Checked == true)
            {

                MainTextBox.CharacterCasing = CharacterCasing.Normal;

                string currentStr = MainTextBox.Text;

                string[] words = currentStr.Split(new string[] { ". ", "! ", "? " }, StringSplitOptions.RemoveEmptyEntries);

                string resultWord;
                string result = "";

                foreach (string word in words)
                {
                    string[] arr = word.Split(new char[] { ' ' });

                    string firstStr = arr[0].Substring(0, 1).ToUpper() + arr[0].Substring(1).ToLower();

                    string simpleStr = "";

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        simpleStr += " " + arr[i + 1].ToLower();
                    }

                    if (arr.Length == 1)
                    {
                        resultWord = firstStr;
                    }
                    else
                    {
                        resultWord = firstStr + simpleStr;
                    }
                    if (word != "")
                    {
                        result += resultWord + ". ";
                    }
                }

                MainTextBox.Text = result;
            }

            if (UpperCaseBtn.Checked == false &&
                LowerCaseBtn.Checked == false &&
                HowInFirstBtn.Checked == false)
            {
                MainTextBox.CharacterCasing = CharacterCasing.Normal;
            }

            if (MainTextBox.Text != "Введите текст...")
            {
                int quantityChars = MainTextBox.TextLength;
                string quantityCharsString = quantityChars.ToString();
                toolStripStatusChars.Text = "Количество символов: " + quantityCharsString;
            }
            else
            {
                int quantityChars = 0;
                string quantityCharsString = quantityChars.ToString();
                toolStripStatusChars.Text = "Количество символов: " + 0.ToString();
            }

            string textFromMainTextBox = MainTextBox.Text.ToString();

            FindTextBox.Text = textFromMainTextBox;
            ChangeTextBox.Text = textFromMainTextBox;
            DeleteTextBox.Text = textFromMainTextBox;
            OptionTextBox.Text = textFromMainTextBox;
        }

        private void UpperCaseBtn_Click(object sender, EventArgs e)
        {
            if (UpperCaseBtn.Checked == true)
            {
                MainTextBox.CharacterCasing = CharacterCasing.Upper;
            }
            if (LowerCaseBtn.Checked == true)
            {
                LowerCaseBtn.Checked = false;
            }
            if (HowInFirstBtn.Checked == true)
            {
                HowInFirstBtn.Checked = false;
            }
        }

        private void LowerCaseBtn_Click(object sender, EventArgs e)
        {
            if (LowerCaseBtn.Checked == true)
            {
                MainTextBox.CharacterCasing = CharacterCasing.Lower;
            }
            if (UpperCaseBtn.Checked == true)
            {
                UpperCaseBtn.Checked = false;
            }
            if (HowInFirstBtn.Checked == true)
            {
                HowInFirstBtn.Checked = false;
            }
        }

        private void предложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UpperCaseBtn.Checked == true)
            {
                UpperCaseBtn.Checked = false;
            }
            if (LowerCaseBtn.Checked == true)
            {
                LowerCaseBtn.Checked = false;
            }
            if (HowInFirstBtn.Checked == true)
            {

                MainTextBox.CharacterCasing = CharacterCasing.Normal;

                string currentStr = MainTextBox.Text;

                string[] words = currentStr.Split(new string[] { ". ", "! ", "? " }, StringSplitOptions.RemoveEmptyEntries);

                string resultWord;
                string result = "";

                foreach (string word in words)
                {
                    string[] arr = word.Split(new char[] { ' ' });

                    string firstStr = arr[0].Substring(0, 1).ToUpper() + arr[0].Substring(1).ToLower();

                    string simpleStr = "";

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        simpleStr += " " + arr[i + 1].ToLower();
                    }

                    if (arr.Length == 1)
                    {
                        resultWord = firstStr;
                    }
                    else
                    {
                        resultWord = firstStr + simpleStr;
                    }
                    if (word != "")
                    {
                        result += resultWord + ". ";
                    }
                }

                MainTextBox.Text = result;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "Введите текст...")
            {
                string changeText = textBoxForChange.Text;
                string someText = textBoxSome.Text;

                int index = MainTextBox.Text.IndexOf(changeText);

                if (index != -1)
                {
                    string resultText = MainTextBox.Text.Replace(changeText, someText);
                    MainTextBox.Text = resultText;
                }
                else
                {
                    MessageBox.Show("Не обнаружено ни одного вхождения!", "Ошибка");
                }
            }
        }

        private void ChangeFontSizeElem_Enter(object sender, EventArgs e)
        {
            ToolStripComboBox tscombobox = (ToolStripComboBox)sender;

            string selectedItem = tscombobox.ComboBox.SelectedItem.ToString();
            int selectedItemInt = int.Parse(selectedItem);

            Font newFont = new Font(MainTextBox.Font.FontFamily, selectedItemInt);

            MainTextBox.Font = newFont;
            FindTextBox.Font = newFont;
            ChangeTextBox.Font = newFont;
            DeleteTextBox.Font = newFont;
            OptionTextBox.Font = newFont;
        }

        private void ChangeFontElem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscombobox = (ToolStripComboBox)sender;

            string selectedFont = tscombobox.ComboBox.SelectedItem.ToString();
            float fontSize = MainTextBox.Font.Size;

            Font newFont = new Font(selectedFont, fontSize);

            MainTextBox.Font = newFont;
            FindTextBox.Font = newFont;
            ChangeTextBox.Font = newFont;
            DeleteTextBox.Font = newFont;
            OptionTextBox.Font = newFont;

            toolStripStatusFont.Text = selectedFont;
        }

        // btnFirstFind
        private void button4_Click(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "Введите текст...")
            {
                if (checkBoxRegister.Checked == true)
                {
                    string text = textBoxFindText.Text;

                    int strLength = text.Length;
                    int index = MainTextBox.Text.IndexOf(text);

                    if (index != -1)
                    {
                        FindTextBox.Focus();
                        FindTextBox.SelectionStart = index;
                        FindTextBox.SelectionLength = strLength;

                        BtnNextFind.Enabled = true;
                        BtnFirstFind.Enabled = false;
                        checkBoxRegister.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Вхождений не обнаружено!", "Ошибка");
                    }
                }
                else
                {
                    string text = textBoxFindText.Text;

                    int strLength = text.Length;

                    string allText = MainTextBox.Text;

                    int index = allText.IndexOf(text, StringComparison.InvariantCultureIgnoreCase);

                    if (index != -1)
                    {
                        FindTextBox.Focus();
                        FindTextBox.SelectionStart = index;
                        FindTextBox.SelectionLength = strLength;

                        BtnNextFind.Enabled = true;
                        BtnFirstFind.Enabled = false;
                        checkBoxRegister.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Вхождений не обнаружено!", "Ошибка");
                    }
                }
            }
        }

        private void BtnNextFind_Click(object sender, EventArgs e)
        {
            if (checkBoxRegister.Checked == true)
            {
                string text = textBoxFindText.Text;

                int strLength = text.Length;
                int index = FindTextBox.SelectionStart + strLength;
                int newIndex = MainTextBox.Text.IndexOf(text, index);

                if (newIndex != -1)
                {
                    FindTextBox.Focus();
                    FindTextBox.SelectionStart = newIndex;
                    FindTextBox.SelectionLength = strLength;
                }
                else
                {
                    MessageBox.Show("Вхождений не обнаружено!", "Ошибка");
                    BtnNextFind.Enabled = false;
                    BtnFirstFind.Enabled = true;
                    checkBoxRegister.Enabled = true;
                }
            }
            else
            {
                string text = textBoxFindText.Text;

                int strLength = text.Length;

                string allText = MainTextBox.Text;

                int index = FindTextBox.SelectionStart + strLength;
                int newIndex = allText.IndexOf(text, index, StringComparison.InvariantCultureIgnoreCase);

                if (newIndex != -1)
                {
                    FindTextBox.Focus();
                    FindTextBox.SelectionStart = newIndex;
                    FindTextBox.SelectionLength = strLength;
                }
                else
                {
                    MessageBox.Show("Все вхождения пройдены!", "Ошибка");
                    BtnNextFind.Enabled = false;
                    BtnFirstFind.Enabled = true;
                    checkBoxRegister.Enabled = true;
                }
            }
        }

        private void buttonSearchSymbol_Click(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "Введите текст...")
            {
                string[] allSentences = MainTextBox.Text.Split('.', '!', '?');

                List<string> allSentencesList = allSentences.ToList();
                allSentencesList.Remove("");

                allSentences = allSentencesList.ToArray();

                for (int i = 0; i < allSentences.Length; i++)
                {
                    string sentence = allSentences[i];
                    sentence = sentence.Trim();
                    allSentences[i] = sentence;
                }

                string symbol = textBoxSearchSymbol.Text.ToString();

                string readyArrayForTextBox = "";

                for (int sentence = 0; sentence < allSentences.Length; sentence++)
                {
                    string[] allWords = allSentences[sentence].Split(' ');

                    int numberOfWords = allWords.Length;
                    int[] numberOfSymbols = new int[numberOfWords];

                    for (int word = 0; word < numberOfWords; word++)
                    {
                        numberOfSymbols[word] = System.Text.RegularExpressions.Regex.Matches(allWords[word], symbol, System.Text.RegularExpressions.RegexOptions.IgnoreCase).Count;
                    }

                    readyArrayForTextBox += "< ";

                    for (int word = 0; word < numberOfWords; word++)
                    {
                        readyArrayForTextBox = readyArrayForTextBox + " " + numberOfSymbols[word].ToString();
                    }

                    readyArrayForTextBox += " >. ";
                }

                textBoxReadySearchSymbol.Text = readyArrayForTextBox;
            }
        }

        private void BtnOption1_Click(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "Введите текст...")
            {
                string currentStr = MainTextBox.Text;

                string[] words = currentStr.Split(new string[] { " ", ". ", ", ", "! ", "? ", ": " }, StringSplitOptions.RemoveEmptyEntries);

                int counter = 0;

                foreach (string word in words)
                {
                    if (word.Length == 5) counter++;
                }

                if (counter == 0)
                {
                    MessageBox.Show("Слов длинною в пять символов не обнаружено!", "Ошибка");
                } 
                else 
                {
                    MessageBox.Show("Количество слов длинною в пять символов: " + counter, "Решение");
                }         
            }
            else
            {
                MessageBox.Show("Дана пустая строка!", "Ошибка");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "Введите текст...")
            {
                string[] sentences = MainTextBox.Text.Split('.', '!', '?');

                string resultStr = "";

                for (int i = 0; i < sentences.Length - 1; i++)
                {
                    string sentenceLower = sentences[i].ToLower();
                    resultStr += i + 1 + ")" + string.Join(" ", sentenceLower.Split().OrderBy(x => x)) + ".\n\n";
                }

                MessageBox.Show(resultStr, "Решение");
            }
            else
            {
                MessageBox.Show("Дана пустой текст!", "Ошибка");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void ChangeFontElem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ChangeFontSizeElem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDeleting(object sender, EventArgs e)
        {

        }

        private void toolStripStatusChars_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        
    }
}
