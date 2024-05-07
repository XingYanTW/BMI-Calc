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

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight, result;

            if (!double.TryParse(textBox1.Text, out height) ||
                !double.TryParse(textBox2.Text, out weight))
            {
                MessageBox.Show("請輸入正確的數值.", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            height = radioButton1.Checked ? height / 100 : height;
            String message = radioButton1.Checked ? $"\n身高: {height*100} 公分" : $"\n身高: {height} 公尺";
            result = weight / (height * height);
            message += $"\n體重: {weight} 公斤";
            message += $"\nBMI: {result:F1}";
            if (result >= 27) message += "\n啊～「肥胖」，需要立刻力行「健康體重管理」囉！";
            else if (result >= 24) message += "\n「體重過重」了，要小心囉，趕快力行「健康體重管理」！";
            else if (result >= 18.5) message += "\n恭喜！「健康體重」，要繼續保持！";
            else message += "\n「體重過輕」，需要多運動，均衡飲食，以增加體能，維持健康！";
            MessageBox.Show(message, "計算結果", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Clear();
            radioButton1.Checked = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/XingYanTW/BMI-Calc");
        }
    }
}
