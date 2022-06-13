using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public class Person
        {
            private string surname = "";
            private string name = "";
            private string patronymic = "";
            private string gender = "";
            private int age = 0;

            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Patronymic
            {
                get { return patronymic; }
                set { patronymic = value; }
            } 

            public string Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value > 0 ? value : -value; }         
            }

            public enum Genders
            {
                Мужской,
                Женский,
                Другой
            };

            public Person(string surname, string name, string patronymic, int age)
            {
                this.surname = surname;
                this.name = name;
                this.patronymic = patronymic;
                this.age = age;
            }

            public Person(string surname, string name) : this(surname, name, "Anonimovus", 0) { }
            public Person(string surname, string name, string patronymic) : this(surname, name, patronymic, 0) { }
            public Person(string surname) : this(surname, "Anonim", "Anonimovus", 0) { }
            public Person() : this("Anonimus", "Anonim", "Anonimovus", 0) { }

            public override string ToString()
            {
                return $"Имя: {name}\n" +
                    $"Фамилия: {surname}\n" +
                    $"Отчество:{patronymic}\n" +
                    $"Возраст: {age}\n" +
                    $"Пол: {gender}";
            }

            public string ToStr(int number)
            {
                string str = number.ToString();
                return str;
            }          
        }

        Person myClass = new Person();

        public Form1()
        {
            InitializeComponent();
        }   

        public Form1(Person person)
        {
            InitializeComponent();
            myClass = person;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form addForm = new Form2(myClass, 0);
            this.Hide();
            addForm.ShowDialog();
        }

        private void BtnViewData_Click(object sender, EventArgs e)
        {
            Form addForm = new Form2(myClass, 1);
            this.Hide();
            addForm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
