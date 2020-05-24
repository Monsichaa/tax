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
    public partial class G5 : Form
    {
        public G5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int nation = int.Parse(numericUpDown1.Text);
            int edusport = int.Parse(numericUpDown2.Text);
            int book = int.Parse(numericUpDown3.Text);
            int otop = int.Parse(numericUpDown4.Text);
            int travalmain = int.Parse(numericUpDown7.Text);
            int travalsecond = int.Parse(numericUpDown8.Text);
            int spendhouse1 = int.Parse(numericUpDown6.Text);
            int spendcar1 = int.Parse(numericUpDown5.Text);
            int spendhouse2 = int.Parse(numericUpDown9.Text);
            int spendcar2 = int.Parse(numericUpDown10.Text);
            int sumall = int.Parse(textBox1.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int outcome;
            int outcomesum;
            if ((travalmain + travalsecond) >= 20000)
            {
                a = 20000;
            }
            else if ((travalmain + travalsecond) < 20000)
            {
                a = travalmain + travalsecond;
            }
            if ((spendhouse1 + spendcar1) >= 100000)
            {
                b = 100000;
            }
            else if ((spendhouse1 + spendcar1) < 100000)
            {
                b = spendhouse1 + spendcar1;
            }
            if ((spendhouse2 + spendcar2) >= 100000)
            {
                c = 100000;
            }
            else if ((spendhouse2 + spendcar2) < 100000)
            {
                c = spendhouse2 + spendcar2;
            }
            {
                outcome = (nation + edusport + book + otop + a + b + c);
                textBox13.Text = outcome.ToString();
                outcomesum = (sumall - (nation + edusport + book + otop + a + b + c));
                textBox12.Text = outcomesum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home r = new home();
            r.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            G6 complete = new G6 ();
            complete.textsum.Text = textBox12.Text;
            complete.Show();
        }
    }
}
