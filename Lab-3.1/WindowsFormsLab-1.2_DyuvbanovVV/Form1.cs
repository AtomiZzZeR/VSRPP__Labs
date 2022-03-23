using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab_1._2_DyuvbanovVV
{
    
    public partial class Form1 : Form
    {
        public int num1, num2, num3;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            if (num1 > num2) {
                num3 = num1 - num2;
                //textBox3.Text = num3.ToString();
                Form2 result = new Form2(this);
                result.Show();
            }
            else
            {
                MessageBox.Show("Error!!! (num1 < num2)", "Title", MessageBoxButtons.OK);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num4 = "";
            textBox1.Text = num4.ToString();
            textBox2.Text = num4.ToString();
            //textBox3.Text = num4.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
  
    }
}
