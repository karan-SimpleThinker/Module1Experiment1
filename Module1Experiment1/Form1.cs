using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1Experiment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtNumber1.Text);
            var num2 = Convert.ToInt32(txtNumber2.Text);
            var total = (num1+num2).ToString();
            txtResult.Text = total.ToString();        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = string.Empty;
            txtNumber2.Text = string.Empty;
            txtResult.Text = string.Empty;
        }
    }
}
