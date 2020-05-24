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
    public partial class G3 : Form
    {
        public G3()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int realty2558 = int.Parse(numericUpDown2.Text);
            int interesthouse = int.Parse(numericUpDown1.Text);
            int outcome2558;
            int outcome4;
            int outcomefinal2558;
            int outcomesum;
            int sumall = int.Parse(textsum.Text);
           {
                outcome2558 = (realty2558 * 20) / 100;
                textBox1.Text = outcome2558.ToString();
                outcome4 = (outcome2558 * 4) / 20;
                textBox2.Text = outcome4.ToString();
                outcomefinal2558 = (interesthouse + outcome4);
                textBox7.Text = outcomefinal2558.ToString();
                outcomesum = sumall - (interesthouse + outcome4);
                textBox6.Text = outcomesum.ToString();
                
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home r = new home();
            r.Show();
            Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int realty2562 = int.Parse(numericUpDown3.Text);
            int interesthouse = int.Parse(numericUpDown1.Text);
            int outcome2562;
            int outcomefinal2562;
            int sumall = int.Parse(textsum.Text);
            int outcomesum;
            int a = 0;
            if (realty2562 <= 5000000)
            {
                a = 200000;
            }
            else if (realty2562 > 5000000)
            {
                a = 0;
            }
            else if (realty2562 < 200000)
            {
                a = 0;
            }
            outcome2562 = a;
            textBox4.Text = outcome2562.ToString();
            outcomefinal2562 = interesthouse + a;
            textBox7.Text = outcomefinal2562.ToString();
            outcomesum = sumall - (interesthouse + a);
            textBox6.Text = outcomesum.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G4 two = new G4();
            two.textBox25.Text = textBox6.Text;
            two.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    }

