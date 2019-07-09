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
    public partial class Fortest : Form
    {
        public Fortest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, i, k;
            double j;
            m = int.Parse(textBox1.Text);
            j = Math.Sqrt(m);
            k = (int)j;
            for (i = 2; i <= k++; i++)
            {
                if (m % k == 0)
                {
                    break;
                }
            }
            if (i > k)
            {
                MessageBox.Show("您输入的是素数");
            }
            else
            {
                MessageBox.Show("您输入的不是是素数");
            }
        }
    }
}