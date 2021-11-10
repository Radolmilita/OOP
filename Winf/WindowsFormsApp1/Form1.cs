using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] outputArray;
        string[] inputArray;

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text.Trim();
            inputArray = s1.Split(new[] { ' ' });

            outputArray = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                outputArray[i] = int.Parse(inputArray[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int sum = 0;
            if (checkBox1.Checked == false & checkBox2.Checked == false)
            {
                for (int i = 0; i < outputArray.Length; i++)
                {
                    sum += outputArray[i];
                }
                label1.Text = $"Сумма элементов массива = {sum.ToString()}";
            }
            if (checkBox2.Checked == true) { 
                for (int i = 0; i < outputArray.Length; i++)
                {
                    if (outputArray[i] < 0) {
                        sum += outputArray[i];
                    }
                    label1.Text = $"Сумма отрицательных элементов массива = {sum.ToString()}";
                }
            }
            if (checkBox1.Checked == true) {
                for (int i = 0; i < outputArray.Length; i++) {
                    if (outputArray[i] > 0) {
                        sum += outputArray[i];
                    }
                }
                label1.Text = $"Сумма положительных элементов массива = {sum.ToString()}";
            }
            if (checkBox1.Checked == true & checkBox2.Checked == true)
            {
                for (int i = 0; i < outputArray.Length; i++)
                {
                    sum += outputArray[i];
                }
                label1.Text = $"Сумма элементов массива = {sum.ToString()}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void снятьФильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void открытьСвязнуюФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.textBox1.Text = textBox2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }
    }
}
