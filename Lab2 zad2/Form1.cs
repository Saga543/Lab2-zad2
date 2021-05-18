using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_zad2
{
    public partial class Form1 : Form
    {
        int rozmiar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true) || (radioButton3.Checked == true))
            {
                if (radioButton4.Checked == true)
                {
                    rozmiar = 16;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar);
                }
                if (radioButton5.Checked == true)
                {
                    rozmiar = 20;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar);
                }
                if (radioButton6.Checked == true)
                {
                    rozmiar = 24;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar);
                }
            }
            if ((radioButton4.Checked == true) || (radioButton5.Checked == true) || (radioButton6.Checked == true))
            {
                if(radioButton4.Checked == true)
                {
                    textBox1.ForeColor = Color.Red;
                }
                if (radioButton5.Checked == true)
                {
                    textBox1.ForeColor = Color.Blue;
                }
                if (radioButton6.Checked == true)
                {
                    textBox1.ForeColor = Color.Orange;
                }
            }
            if ((checkBox1.Checked == true) || (checkBox2.Checked == true) || (checkBox3.Checked == true))
            {
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar, FontStyle.Bold | FontStyle.Italic);
                }
                else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar, FontStyle.Bold | FontStyle.Underline);
                }
                else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar, FontStyle.Italic | FontStyle.Underline);
                }
                else if (checkBox1.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar, FontStyle.Bold);
                }
                else if (checkBox2.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar, FontStyle.Italic);
                }
                else if (checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar, FontStyle.Underline);
                }
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
