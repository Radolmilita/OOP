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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            textBox1.Text = form1.textBox2.Text;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            form1.textBox2.Text = textBox2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
