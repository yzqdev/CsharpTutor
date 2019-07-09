using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Whiletest : Form
    {
        public Whiletest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n, r, g, h, p;
            m = Convert.ToInt32(textBox1.Text);
            n = Convert.ToInt32(textBox2.Text);
            p = m * n;
            while ((r = m % n) != 0)
            {
                m = n;
                n = r;
            }
            g = n;
            h = p / g;
            //余数为零的除数就是最大公约数
            textBox3.Text = Convert.ToString(g);
            textBox4.Text = Convert.ToString(h);
        }
    }
}