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
    public partial class G4 : Form
    {
        public G4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void G4_Load(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox25.Text);
            int outcome1;
            {
                outcome1 = ((month * 10) / 100);
                textBox20.Text = outcome1.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

            int education = int.Parse(textBox1.Text);
            int sport = int.Parse(textBox13.Text);
            int hospital = int.Parse(textBox14.Text);
            int pub = int.Parse(textBox15.Text);
            int outcome2;
            {
                outcome2 = ((education * 2) + (sport * 2) + (hospital * 2) + (pub * 2));
                textBox21.Text = outcome2.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int normal = int.Parse(textBox19.Text);
            int flood = int.Parse(textBox18.Text);
            int party = int.Parse(numericUpDown2.Text);
            int outcome3;
            {
                outcome3 = normal + flood + party;
                textBox24.Text = outcome3.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int tan1 = int.Parse(textBox21.Text);
            int tan2 = int.Parse(textBox24.Text);
            int moneyten = int.Parse(textBox20.Text);
            int sumall = int.Parse(textBox25.Text);
            int outcome4;
            int outcomesum;
            int tan = 0;
            if ((tan1 + tan2) > moneyten)
            {
                tan = tan + moneyten;
            }
            else if ((tan1 + tan2) < moneyten)
            {
                tan = tan1 + tan2;
            }
            {
                outcome4 = tan;
                textBox22.Text = outcome4.ToString();
                outcomesum = sumall - tan;
                textBox23.Text = outcomesum.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            home r = new home();
            r.Show();
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            G5 one = new G5();
            one.textBox1.Text = textBox23.Text;
            one.Show();
        }
    }
}
