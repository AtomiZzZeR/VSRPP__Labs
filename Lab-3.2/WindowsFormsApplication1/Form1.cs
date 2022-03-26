using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int num, radio = 1;
        string str;
        bool check;
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           radio = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radio = 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);

            switch (num)
            {
                case 1:
                    if (radio == 1)
                    {
                        str = "Понедельник";
                    } else if (radio == 2) {
                        str = "Monday";
                    }
                    
                    check = true;
                    break;
                case 2:
                    if (radio == 1)
                    {
                        str = "Вторник";
                    }
                    else if (radio == 2)
                    {
                        str = "Tuesday";
                    }
                    check = true;
                    break;
                case 3:
                    if (radio == 1)
                    {
                        str = "Среда";
                    }
                    else if (radio == 2)
                    {
                        str = "Wednesday";
                    }
                    check = true;
                    break;
                case 4:
                    if (radio == 1)
                    {
                        str = "Четверг";
                    }
                    else if (radio == 2)
                    {
                        str = "Thursday";
                    }
                    check = true;
                    break;
                case 5:
                    if (radio == 1)
                    {
                        str = "Пятница";
                    }
                    else if (radio == 2)
                    {
                        str = "Friday";
                    }
                    check = true;
                    break;
                case 6:
                    if (radio == 1)
                    {
                        str = "Суббота";
                    }
                    else if (radio == 2)
                    {
                        str = "Saturday";
                    }
                    check = true;
                    break;
                case 7:
                    if (radio == 1)
                    {
                        str = "Воскресенье";
                    } else if (radio == 2) {
                        str = "Sunday";
                    };
                    check = true;
                    break;
                default:
                    MessageBox.Show("Дня недели под таким номером не существует!");
                    check = false;
                    break;
            }

            if (check)
            {
                MessageBox.Show("Под номером " + num + " день недели: " + '"' + str + '"', "Сообщение");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
