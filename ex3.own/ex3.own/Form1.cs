using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3.own
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double u = 0;

            textBox4.Text = "Результаты выполнения работы ст. Чистякова Д.С. " + Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;

            if (radioButton1.Checked == true)
            {
                textBox4.Text += "Умноженное на sin(x) " + Environment.NewLine;
                u = Math.Sin(x) * ((y * y + 2 * Math.Cos(z) * Math.Cos(z)) / Math.Sin(x + y));
            }

            else if (radioButton2.Checked == true)
            {
                textBox4.Text += "Умноженное на cos(x) " + Environment.NewLine;
                u = Math.Cos(x) * ((y * y + 2 * Math.Cos(z) * Math.Cos(z)) / Math.Sin(x + y));
            }

            else if (radioButton3.Checked == true)
            {
                textBox4.Text += "Умноженное на exp(x) " + Environment.NewLine;
                u = Math.Exp(x) * ((y * y + 2 * Math.Cos(z) * Math.Cos(z)) / Math.Sin(x + y));
            }

            else textBox4.Text += "Не выбрано значение радиокнопки" + Environment.NewLine;

            textBox4.Text += "Результат: u = " + u.ToString() + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            this.Text = "Лабораторная работа №3 Чистякова Дмитрия";
        }
    }
}
