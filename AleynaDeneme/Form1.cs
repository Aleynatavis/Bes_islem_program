using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AleynaDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox1.Text);
            double s2 = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                label1.Text = (s1 + s2).ToString();
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = (s1 - s2).ToString();
            }
            if (radioButton3.Checked == true)
            {
                label1.Text = (s1 * s2).ToString();
            }
            if (radioButton4.Checked == true)
            {
                label1.Text = (s1 / s2).ToString();
            }
            if (radioButton5.Checked == true)
            {
                label1.Text = (s1 % s2).ToString();
            }






        }

        double tam;

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tam = Convert.ToDouble(textBox3.Text);
            label3.Text = tam.ToString();

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            tam = Convert.ToDouble(textBox3.Text);
            double sonuc = tam - (tam * 0.20);
            label3.Text =sonuc.ToString();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            tam = Convert.ToDouble(textBox3.Text);
            double sonuc = tam - (tam * 0.50);
            label3.Text = sonuc.ToString();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox3.Text = "50";
            label3.Text = textBox3.Text;
            radioButton6.Checked = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox3.Text = "100";
            label3.Text = textBox3.Text;
            radioButton6.Checked = true;


        }
    }
}
