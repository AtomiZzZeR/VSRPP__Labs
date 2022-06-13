using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8VSRPP
{
    public class ClassPrepod : ClassPerson
    {
        private int staj = 0;
        private PostEnum _postEnum;
        
        public string Post
        {
            get { return _postEnum.ToString(); }
            set 
            { 
               Enum.TryParse(value, out _postEnum);
            }
        }

        public int Staj
        {
            get 
            { 
                return staj;
            }
            set
            {
                if (value.ToString() == "")
                {
                    staj = 0;
                }
                else
                {
                    staj = value;
                }
            }
        }

        public enum PostEnum
        {
            Доцент,
            Профессор,
            Старший,
            КанТехНаук      
        }

        public ClassPrepod() : this("Аноним", "Анонимов", 0, 1) { }

        public ClassPrepod(string name, string surname, int age, int staj) : base(name, surname, age)
        {
            this.staj = staj;
        }

        public override string ToString()
        {
           
            string str = $"Преподаватель |||" +
                $" Имя: {Name};" +
                $" Фамилия: {Surname};" +
                $" Возраст: {Age} лет;" +
                $" Пол: {_genderEnum};" +
                $" Должность: {_postEnum};" +
                $" Стаж: {Staj} лет";
            return str;
        }

        public override bool Equals(object obj)
        {
            if (obj is ClassPrepod)
            {
                ClassPrepod cpre = (ClassPrepod)obj;
                if (Name == cpre.Name && Surname == cpre.Surname && Age == cpre.Age && Staj == cpre.Staj)
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
