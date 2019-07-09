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
    public partial class Shuixianhua : Form
    {
        public Shuixianhua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "水仙花数有:";

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        for (int k = 0; k < 10; k++)
            //        {
            //            m = i * 100 + j * 10 + k;
            //            if (i * i * i + j * j * j + k * k * k == m)
            //            {
            //                textBox1.Text = textBox1.Text + "\r\n" + Convert.ToString(m);
            //            }
            //        }
            //    }
            //}
            int m;
            for (int i = 100; i < 999; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;
                if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
                {
                    textBox1.Text = textBox1.Text + "\r\n" + Convert.ToString(i);
                }
            }
        }
    }
}