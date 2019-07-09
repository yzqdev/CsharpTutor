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
    public partial class Switcht : Form
    {
        public Switcht()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int score;
                score = Convert.ToInt32(textBox1.Text);
                if (score >= 0 && score <= 100)
                {
                    switch (score / 10)
                    {
                        case 10:
                        case 9:
                            textBox2.Text = "优秀";
                            break;

                        case 8:
                            textBox2.Text = "良好";
                            break;

                        case 7:
                            textBox2.Text = "中等";
                            break;

                        case 6:
                            textBox2.Text = "及格";
                            break;

                        default:
                            textBox2.Text = "不及格";
                            break;
                    }
                }
                else
                {
                    textBox2.Text = "成绩输入有误!";
                }
            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入百分制成绩!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}