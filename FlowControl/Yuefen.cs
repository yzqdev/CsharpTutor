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
    public partial class Yuefen : Form
    {
        public Yuefen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(textBox1.Text);

                try
                {
                    int month = Convert.ToInt32(textBox2.Text);//1-12
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;//声明一个变量用来存储天数
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;

                            case 2:
                                //由于2月 有平年和闰年的不同  所以首先要判断一下当年是不是闰年
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            //4 6  9 11
                            default:
                                day = 30;
                                break;
                        }

                        label3.Text = textBox1.Text + "年" + textBox2.Text + "月有" + day + "天";
                    }//if判断的括号
                    else
                    {
                        MessageBox.Show("输入的月份不符合要求，程序退出");
                    }
                }//try月份括号
                catch (Exception ex)
                {
                    MessageBox.Show("输入的月份有误，程序退出");
                }
            }//try年份的括号
            catch (Exception ex)
            {
                MessageBox.Show("输入的年份有误，程序退出");
            }
        }
    }
}