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
    public partial class Wanshutest : Form
    {
        public Wanshutest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Wanshutest_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int rangeMax = int.Parse(textBox1.Text);
            richTextBox1.Text = $"{rangeMax}以内的完数为:\n";
            for (int i = 2; i <= rangeMax; i++)
            {
                string str = "1";
                int s = 1;
                int a = 0;
                for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        a = i / j;
                        s += j + a;
                        str += string.Format("+{0}+{1}", j, a);
                    }
                }
                if (s == i)
                {
                    str += "\n";
                    richTextBox1.Text += i.ToString() + "=" + str;
                }
            }
        }
    }
}