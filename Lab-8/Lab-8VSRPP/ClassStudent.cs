using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8VSRPP
{
    public class ClassStudent : ClassPerson
    {
        private string speciality = " ";
        private int course = 0;

        public string Speciality
        {
            get
            {
                return speciality;
            }
            set
            {
                if (value == "")
                {
                    speciality = "Безспециальный";
                }
                else
                {
                    speciality = value;
                }
            }
        }

        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                if (value.ToString() == "")
                {
                    course = 0;
                }
                else
                {
                    course = value;
                }
            }
        }

        public ClassStudent() : this("Аноним", "Анонимов", 0, "Неизвестно", 1) { }

        public ClassStudent(string name, string surname, int age, string speciality, int course)
            : base(name, surname, age)
        {
            this.speciality = speciality;
            this.course = course;
        }

        public override string ToString()
        {
            

            string str = $"Студент || Имя: {Name}; Фамилия: {Surname}; Возраст: {Age} лет; Пол: {_genderEnum}; Специальность: {Speciality}; Курс: {Course}-ый";
            return str;
        }

        public override bool Equals(object obj)
        {
            if (obj is ClassStudent)
            {
                ClassStudent cstu = (ClassStudent)obj;
                if (Name == cstu.Name && Surname == cstu.Surname && Age == cstu.Age && Speciality == cstu.Speciality && Course == cstu.Course)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
