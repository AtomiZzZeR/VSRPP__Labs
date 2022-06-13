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
    public partial class StudentForm : Form
    {
        List<ClassPerson> person = new List<ClassPerson>();

        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(List<ClassPerson> person)
        {
            InitializeComponent();
            this.person = person;

            EnumActive();

            ComboBoxGender.KeyPress += (sender, e) => e.Handled = true;
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
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
            string[] arr = Enum.GetNames(typeof(ClassPerson.GenderEnum));

            for (int i = 0; i < arr.Length; i++)
            {
                ComboBoxGender.Items.Add(arr[i]);
            }
        }

        private void AddData()
        {
            string name = TextBoxName.Text.ToString();
            string surname = TextBoxSurname.Text.ToString();
            string age = TextBoxAge.Text.ToString();
            string gender = ComboBoxGender.Text;
            string speciality = TextBoxSpeciality.Text.ToString();
            string course = TextBoxCourse.Text.ToString();

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
            else if (course.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Неверный формат курса!", "Error");
            }
            else if (int.Parse(course) <= 0 || int.Parse(course) >= 6)
            {
                MessageBox.Show("Неправильный курс!", "Error");
            }
            else
            {
                ClassStudent student = new ClassStudent
                {
                    Name = name,
                    Surname = surname,
                    Age = int.Parse(age),
                    Gender = gender,
                    Speciality = speciality,
                    Course = int.Parse(course),
                };

                person.Add(student);

                Form newForm = new MainForm(person);
                Form.ActiveForm.Close();
                newForm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
