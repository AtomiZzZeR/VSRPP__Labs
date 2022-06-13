using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8VSRPP
{
    public partial class PrepodForm : Form
    {
        List<ClassPerson> person = new List<ClassPerson>();

        public PrepodForm()
        {
            InitializeComponent();
        }

        public PrepodForm(List<ClassPerson> person)
        {
            InitializeComponent();
            this.person = person;

            EnumActive();

            ComboBoxGender.KeyPress += (sender, e) => e.Handled = true;
            ComboBoxPost.KeyPress += (sender, e) => e.Handled = true;
        }

        private void BtnAddPrepod_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Form newForm = new MainForm();
            Form.ActiveForm.Close();
            newForm.Show();
        }

        private void EnumActive()
        {
            string[] arr1 = Enum.GetNames(typeof(ClassPerson.GenderEnum));

            for (int i = 0; i < arr1.Length; i++)
            {
                ComboBoxGender.Items.Add(arr1[i]);
            }

            string[] arr2 = Enum.GetNames(typeof(ClassPrepod.PostEnum));

            for (int i = 0; i < arr2.Length; i++)
            {
                ComboBoxPost.Items.Add(arr2[i]);
            }
        }

        private void AddData()
        {
            string name = TextBoxName.Text.ToString();
            string surname = TextBoxSurname.Text.ToString();
            string age = TextBoxAge.Text.ToString();
            string gender = ComboBoxGender.Text;
            string post = ComboBoxPost.Text;
            string staj = TextBoxStaj.Text.ToString();

            if (name.Any(n => char.IsNumber(n)))
            {
                MessageBox.Show("Неверный формат имени!", "Error");
            }
            else if (surname.Any(n => char.IsNumber(n)))
            {
                MessageBox.Show("Неверный формат фамилии!", "Error");
            }
            else if (age.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Неверный формат возраста!", "Error");
            }
            else if (int.Parse(age) <= 0 || int.Parse(age) > 120)
            {
                MessageBox.Show("Неправильный возраст!", "Error");
            }
            else if (gender == "")
            {
                MessageBox.Show("Не выбран пол!", "Error");
            }
            else if (post == "")
            {
                MessageBox.Show("Не выбран пол!", "Error");
            }
            else if (staj.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Неверный формат стажа!", "Error");
            }
            else if (int.Parse(staj) <= 0 || int.Parse(staj) > 100)
            {
                MessageBox.Show("Неправильный стаж!", "Error");
            }
            else if (int.Parse(staj) > int.Parse(age))
            {
                MessageBox.Show("Стаж не может быть больше возраста!", "Error");
            }
            else
            {
                ClassPrepod prepod = new ClassPrepod
                {
                    Name = name,
                    Surname = surname,
                    Age = int.Parse(age),
                    Gender = gender,
                    Post = post,
                    Staj = int.Parse(staj),
                };

                person.Add(prepod);

                Form newForm = new MainForm(person);
                Form.ActiveForm.Close();
                newForm.Show();
            }
        }

        private void PrepodForm_Load(object sender, EventArgs e)
        {

        }
    }
}
