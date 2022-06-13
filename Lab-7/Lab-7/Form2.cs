using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_7.Form1;

namespace Lab_7
{
    public partial class Form2 : Form
    {
        public Person myClass = new Person();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Person person, int number)
        {
            if (number == 0)
            {
                InitializeComponent();
                myClass = person;

                string[] array = Enum.GetNames(typeof(Person.Genders)); 

                for (int i = 0; i < array.Length; i++)
                {
                    comboBox1.Items.Add(array[i]);
                }

                comboBox1.KeyPress += (sender, e) => e.Handled = true;
            }
            else
            {
                InitializeComponent();
                myClass = person;

                string[] array = Enum.GetNames(typeof(Person.Genders));

                for (int i = 0; i < array.Length; i++)
                {
                    comboBox1.Items.Add(array[i]);
                }

                textBoxSurname.Text = myClass.Surname;
                textBoxName.Text = myClass.Name;
                textBoxPatron.Text = myClass.Patronymic;
                textBoxAge.Text = myClass.ToStr(myClass.Age);
                comboBox1.Text = myClass.Gender;

                textBoxSurname.Enabled = false;
                textBoxName.Enabled = false;
                textBoxPatron.Enabled = false;
                textBoxAge.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string surname = textBoxSurname.Text.ToString();
            string name = textBoxName.Text.ToString();
            string patron = textBoxPatron.Text.ToString();
            string age = textBoxAge.Text.ToString();
            int gender = comboBox1.SelectedIndex;

            if (surname == "")
            {
                MessageBox.Show("Не введена фамилия!", "Ошибка");
            }
            else if (name == "")
            {
                MessageBox.Show("Не введено имя!", "Ошибка");
            }
            else if (patron == "")
            {
                MessageBox.Show("Не введена фамилия!", "Ошибка");
            }
            else if (age == "" || age.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Не введён возраст или не правильный формат!", "Ошибка");
            }
            else if (gender.ToString() == "")
            {
                MessageBox.Show("Не выбран пол!", "Ошибка");
            }
            else
            {
                string city = Enum.GetName(typeof(Person.Genders), Name);
                myClass.Surname = surname;
                myClass.Name = name;
                myClass.Patronymic = patron;
                myClass.Age = int.Parse(age);
                myClass.Gender = city;

                Form addForm = new Form1(myClass);
                Form.ActiveForm.Close();
                addForm.Show();
            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
