using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8VSRPP
{
    public class ClassPerson
    {
        private string name = " ";
        private string surname = " ";
        private int age = 0;
        public GenderEnum _genderEnum;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    name = "Безымянный";
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value == "")
                {
                    surname = "Безфамильный";
                }
                else
                {
                    surname = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value.ToString() == "")
                {
                    age = 1;
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Gender
        {
            get { return _genderEnum.ToString(); }
            set
            {
                Enum.TryParse(value, out _genderEnum);
            }
        }

        public enum GenderEnum
        {
            Мужской,
            Женский,
            Другой
        };

        public ClassPerson() : this("Аноним", "Анонимов", 0) { }

        public ClassPerson(string name) : this(name, "Анонимов", 0) { }

        public ClassPerson(string name, string surname) : this(name, surname, 0) { }

        public ClassPerson(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string ToString(int num)
        {
            string str = num.ToString();
            return str;
        }

        public virtual string ToString()
        {
            string str = $"Имя: {name}; Фамилия: {surname}; Возраст: {age} лет";
            return str;
        }

        public virtual bool Equals(object obj)
        {
            if (obj is ClassPerson)
            {
                ClassPerson cper = (ClassPerson)obj;
                if (Name == cper.Name && Surname == cper.Surname && Age == cper.Age)
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
