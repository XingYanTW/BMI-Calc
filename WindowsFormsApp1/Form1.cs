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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight, result;

            if (!double.TryParse(textBox1.Text, out height) ||
                !double.TryParse(textBox2.Text, out weight))
            {
                MessageBox.Show("Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String message = "BMI Calc Result:";
            if (radioButton1.Checked)
            {
                message += $"\nHeight: {height} cm";
                result = weight/((height / 100)* (height / 100));
            }
            else
            {
                message += $"\nHeight: {height} m";
                result = weight / (height * height);
            }
            message += $"\nWeight: {weight} kg";
            message += $"\nBMI: {result:F1}";

            MessageBox.Show(message, "Result", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Clear();
            radioButton1.Checked = true;
        }
    }
}
