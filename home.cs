﻿using System;
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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {
            G1 a = new G1();
            a.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            G2 b = new G2();
            b.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            G3 c = new G3();
            c.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            G4 d = new G4();
            d.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            G5 f = new G5();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            G1 one = new G1();
            one.textsum.Text = textBox4.Text;
            one.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox5.Text);
            int pasee = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            int sums = 0;
            if ((((month * 12) + pasee + other) * 50 / 100) > 100000)
            {
                sums = (((month * 12) + pasee + other) - 100000);
            }
            else if ((((month * 12) + pasee + other) * 50 / 100) <= 100000)
            {
                sums = ((month * 12) + pasee + other) * 50 / 100;
            }
            {
                outcome = sums;
                textBox4.Text = outcome.ToString();
            }
        }
    }
}