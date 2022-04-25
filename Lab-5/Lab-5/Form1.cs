using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = i + 1;
                cBoxRows.Items.Add(numbers[i]);
                cBoxColumns.Items.Add(numbers[i]);
            }

            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            comboBox2.KeyPress += (sender, e) => e.Handled = true;
            textBox1.KeyPress += (sender, e) => e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strRows = comboBox1.SelectedIndex.ToString();
            string strColumns = comboBox2.SelectedIndex.ToString();

            int numRows = Convert.ToInt32(strRows);
            int numColumns = Convert.ToInt32(strColumns);

            int[,] arr = new int[numRows, numColumns];

            if (numRows != 0 || numColumns != 0)
            {
                dataGridView1.RowCount = numRows;
                dataGridView1.ColumnCount = numColumns;

                Random rand = new Random();

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numColumns; j++)
                    {
                        arr[i, j] = rand.Next(7);
                    }
                }

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numColumns; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Matrix do not have 0 rows or 0 columns!", "Error...");
            }

            int counter = 0;
            Boolean flag = true;

            for (int i = 0; i < numColumns; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    if (arr[j, i] == 0)
                    {
                        flag = false;
                        break;
                    }
                    flag = true;
                }
                if (flag == false) continue;
                counter++;
            }

            textBox1.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
