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
    public partial class G2 : Form
    {
        public G2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            home r = new home();
            r.Show();
            Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDown7.Enabled = true;
            }
            else
            {
                numericUpDown7.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDown1.Text);
            int b = int.Parse(numericUpDown2.Text);
            int c = int.Parse(numericUpDown3.Text);
            int d = int.Parse(numericUpDown4.Text);
            int er = int.Parse(numericUpDown5.Text);
            int f = int.Parse(numericUpDown6.Text);
            int g = int.Parse(numericUpDown7.Text);
            int sumall = int.Parse(textsum.Text);
            int z = 0;
            int outcome;
            int outcome2;
            if ((b + c) > 100000)
            {
                z = 100000;
            }
            else if ((b + c) < 100000)
            {
                z = b + c;
            }
            {
                outcome = (a + z + d + er + g + f);
                textBox5.Text = outcome.ToString();
                outcome2 = sumall - (a + z + d + er + g + f);
                textBox2.Text = outcome2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G3 two = new G3();
            two.textsum.Text = textBox2.Text;
            two.Show();

        }
    }
 }

