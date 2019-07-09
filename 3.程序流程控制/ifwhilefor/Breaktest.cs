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
    public partial class Breaktest : Form
    {
        public Breaktest()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    break;
                }
                textBox1.Text = textBox1.Text + "\r\n" + Convert.ToString(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                textBox2.Text = textBox2.Text + "\r\n" + Convert.ToString(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    goto begin;
                }
                textBox3.Text = textBox3.Text + "\r\n" + Convert.ToString(i);
            }
            begin:
            textBox3.Text = textBox3.Text + "\r\n" + "goto跳出";
        }
    }
}