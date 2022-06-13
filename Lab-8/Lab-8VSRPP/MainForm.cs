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
    public partial class MainForm : Form
    {
        List<ClassPerson> person = new List<ClassPerson>();

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(List<ClassPerson> person)
        {
            InitializeComponent();
            this.person = person;
        }

        public MainForm(List<PrepodForm> person1)
        {
        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void BtnCheckData_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddData()
        {
            if (RadioBtnStudent.Checked == true)
            {
                StudentForm studentf = new StudentForm(person);
                this.Hide();
                studentf.ShowDialog();
            }
            else if (RadioBtnPrepod.Checked == true)
            {
                PrepodForm prepodf = new PrepodForm(person);
                this.Hide();
                prepodf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы не выбрали объект!", "Error");
            }
        }

        private void Check()
        {
            for (int i = 0; i < person.Count; i++)
            {
                listBox1.Items.Add(person[i].ToString());
            }

            if (RadioBtnStudent.Checked == true)
            {
                listBox1.Items.Clear();

                int allValues = person.Count();

                List<int> list = new List<int>();

                int counter = 0;

                for (int elem = 0; elem < allValues; elem++)
                {
                    if (person[elem] is ClassStudent)
                    {
                        list.Add(elem);
                        counter++;
                    }
                }

                if (counter != 0)
                {
                    for (int elem = 0; elem < list.Count(); elem++)
                    {
                        listBox1.Items.Add(person[elem].ToString());
                    }
                }
            }
            else if (RadioBtnPrepod.Checked == true)
            {
                listBox1.Items.Clear();

                    int allValues = person.Count();

                    List<int> list = new List<int>();

                    int counter = 0;

                    for (int elem = 0; elem < allValues; elem++)
                    {
                        if (person[elem] is ClassPrepod)
                        {
                            list.Add(elem);
                            counter++;
                        }
                    }

                    if (counter != 0)
                    {
                        for (int elem = 0; elem < list.Count(); elem++)
                        {
                            listBox1.Items.Add(person[elem].ToString());
                        }
                    }
                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
