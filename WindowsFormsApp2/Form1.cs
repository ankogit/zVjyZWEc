using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SomeClass someEx = new SomeClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Данный не введины!");
            else
                MessageBox.Show(Convert.ToString(someEx.Summ(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text))));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class SomeClass
    {
        public double Summ(double a, double b)
        {
            return a + b;
        }

    }
}
