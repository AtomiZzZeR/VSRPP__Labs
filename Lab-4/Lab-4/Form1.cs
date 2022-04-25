using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public int x = 0;
        double[] arr;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "3", "5", "7", "10", "15", "20", "25" });

            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            textBox1.KeyPress += (sender, e) => e.Handled = true;
            textBox2.KeyPress += (sender, e) => e.Handled = true;
            textBox3.KeyPress += (sender, e) => e.Handled = true;
            textBox4.KeyPress += (sender, e) => e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr = new double[x];

            dataGridView1.RowCount = x;

            Random rand = new Random();

            for (int i = 0; i < x; i++)
            {
                double randNum = (rand.NextDouble() * (10 - (-10))) + (-10);

                arr[i] = Math.Round(randNum, 5);

                dataGridView1.Rows[i].Cells[0].Value = arr[i];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = comboBox1.SelectedItem.ToString();
            x = int.Parse(select);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }

            textBox1.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double max = -10000, min = 10000;
            int maxIndex = 0, minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                double abs = Math.Abs(arr[i]);

                if (abs > max)
                {
                    max = abs;
                    maxIndex = i;
                }
            }

            textBox3.Text = max.ToString();

            for (int i = 0; i < arr.Length; i++)
            {
                double abs = Math.Abs(arr[i]);

                if (abs < min)
                {
                    min = abs;
                    minIndex = i;
                }
            }

            textBox4.Text = min.ToString();

            double mul = 1;

            for (int i = Math.Min(maxIndex, minIndex); i <= Math.Max(maxIndex, minIndex); i++)
            {
                mul *= arr[i]; 
            }

            textBox2.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            /*for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; i++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        double sort = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = sort;
                    }
                }
            }*/

            dataGridView2.RowCount = x;

            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = arr[i];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
