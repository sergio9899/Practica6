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
        double x, y;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            result = x * y;
            textBox3.Text = result.ToString();
        }
        private void Division_Click(object sender, EventArgs e) 
        {
            
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            if (y != 0)
            { 
                double res = x / y;
                textBox3.Text = Convert.ToString(res);
            }
            else
                MessageBox.Show("no se puede realizar");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suma_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            result = x + y;
            textBox3.Text = result.ToString();
        }

        private void Resta_Click(object sender, EventArgs e)
        {

            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            result = x - y;
            textBox3.Text = result.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
