using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxx
{
    public partial class G1 : Form
    {
        public G1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int before = int.Parse(numericUpDown1.Text);
            int since = int.Parse(numericUpDown2.Text);
            int Pregnant = int.Parse(numericUpDown3.Text);
            int disabled = int.Parse(numericUpDown4.Text);
            int sumall = int.Parse(textsum.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int ex = 0;
            int outcome1;
            int outcome2;
            if (radioButton5.Checked == true)
            {
                a = a + 60000;
            }
            if (checkBox1.Checked == true)
            {
                b = b + 30000;
            }
            if (checkBox2.Checked == true)
            {
                c = c + 30000;
            }
            if (checkBox3.Checked == true)
            {
                d = d + 30000;
            }
            if (checkBox4.Checked == true)
            {
                ex = ex + 30000;
            }

            before = before * 30000;
            since = since * 60000;
            disabled = disabled * 60000;
            {
                outcome1 = a + b + c + d + ex + before + since + Pregnant + disabled;
                textBox5.Text = outcome1.ToString();
                outcome2 = sumall - (a + b + c + d + ex + before + since + Pregnant + disabled);
                textBox1.Text = outcome2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            home r = new home();
            r.Show();
            Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
         

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G2 two= new G2();
            two.textsum.Text = textBox1.Text;
            two.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
