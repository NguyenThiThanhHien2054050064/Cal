using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            // {
            //     double a = double.Parse(textBox1.Text);
            //     double b = double.Parse(textBox2.Text);
            //     double c = a + b;
            //     textBox3.Text = c.ToString();
            // }    
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            calculation c = new calculator.calculation(a, b);
            textBox3.Text = c.Execute("+").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //double a = double.Parse(textBox1.Text);
            //double b = double.Parse(textBox2.Text);
            //double c = a - b;
            //textBox3.Text = c.ToString();
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            calculation c = new calculator.calculation(a, b);
            textBox3.Text = c.Execute("-").ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            calculation c = new calculator.calculation(a, b);
            textBox3.Text = c.Execute("*").ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            calculation c = new calculator.calculation(a, b);
            textBox3.Text = c.Execute("/").ToString();
        }
    }
}
