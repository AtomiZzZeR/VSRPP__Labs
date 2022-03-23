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
            static Random rnd = new Random();
            int rand = rnd.Next(1, 4);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 1;

            if (num1 == rand)
            {
                MessageBox.Show("Вы угадали число :)", "Сообщение");
            }
            else
            {
                MessageBox.Show("Вы не угадали число :( Повезёт в следующий раз ", "Сообщение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num2 = 2;

            if (num2 == rand)
            {
                MessageBox.Show("Вы угадали число :)", "Сообщение");
            }
            else
            {
                MessageBox.Show("Вы не угадали число :( Повезёт в следующий раз ", "Сообщение");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num3 = 3;

            if (num3 == rand)
            {
                MessageBox.Show("Вы угадали число :)", "Сообщение");
            }
            else
            {
                MessageBox.Show("Вы не угадали число :( Повезёт в следующий раз ", "Сообщение");
            }
        }
    }
}
