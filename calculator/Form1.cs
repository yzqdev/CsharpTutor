using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public double pi = 3.1415926535;
        public double ee = 2.71828;
        public sb[] numberBT = new sb[10];
        public sb dotBT = new sb();
        public sb ansBT = new sb();
        public sb signBT = new sb();
        public bool equalC = false;
        public computer cal = new computer();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Size = new Size(550, 400);
            button6.Location = new Point(13, 290);
            button7.Location = new Point(121, 290);
            groupBox1.Size = new Size(200, 200);
            groupBox1.Location = new Point(17, 83);
            groupBox2.Size = new Size(300, 265);
            groupBox2.Location = new Point(224, 83);
            for (int i = 0; i < 10; i++)
            {
                numberBT[i] = new sb();
                numberBT[i].Size = new Size(40, 40);
                this.groupBox1.Controls.Add(numberBT[i]);
                numberBT[i].index = i;
                numberBT[i].Text = i.ToString();
                numberBT[i].Font = new Font("楷体", 20, FontStyle.Bold);
                numberBT[i].TextAlign = button2.TextAlign;
                numberBT[i].Click += new EventHandler(this.numberBT_Click);
            }
            for (int i = 1; i < 10; i++)
            {
                numberBT[i].Location = new Point(10 + 45 * ((i - 1) % 4), 15 + 45 * ((i - 1) / 4));
                numberBT[i].Visible = true;
            }
            numberBT[0].Location = new Point(55, 105);
            numberBT[0].Visible = true;
            dotBT.Size = new Size(40, 40);
            dotBT.Font = new Font("楷体", 20, FontStyle.Bold);
            dotBT.TextAlign = button2.TextAlign;
            dotBT.Text = ".";
            dotBT.Location = new Point(100, 105);
            this.groupBox1.Controls.Add(dotBT);
            dotBT.Visible = true;
            dotBT.Click += new EventHandler(this.dotBT_Click);
            ansBT.Size = new Size(175, 40);
            ansBT.Font = new Font("楷体", 12, FontStyle.Bold);
            ansBT.TextAlign = button2.TextAlign;
            ansBT.Text = "ANS";
            ansBT.Location = new Point(10, 150);
            this.groupBox1.Controls.Add(ansBT);
            ansBT.Visible = true;
            ansBT.Click += new EventHandler(this.ansBT_Click);
            signBT.Size = new Size(40, 40);
            signBT.Font = new Font("楷体", 10, FontStyle.Bold);
            signBT.TextAlign = button2.TextAlign;
            signBT.Text = "-";
            signBT.Location = new Point(145, 105);
            this.groupBox1.Controls.Add(signBT);
            signBT.Visible = true;
            signBT.Click += new EventHandler(this.signBT_Click);
        }

        public void signBT_Click(object sender, System.EventArgs e)
        {
            cal.sign = (-1) * cal.sign;
        }

        private void numberBT_Click(object sender, System.EventArgs e)
        {
            if (label1.Text != "0" && !equalC)
            {
                label1.Text += (sender as sb).Text;
            }
            else
            {
                label1.Text = (sender as sb).Text;
            }
            if (dotBT.Enabled == true)
            {
                cal.number1 = cal.number1 * 10 + (sender as sb).index;
            }
            else
            {
                cal.number2 = cal.number2 * 10 + (sender as sb).index;
            }
            equalC = false;
        }

        private void dotBT_Click(object sender, System.EventArgs e)
        {
            label1.Text += (sender as sb).Text;
            dotBT.Enabled = false;
        }

        private void ansBT_Click(object sender, System.EventArgs e)
        {
            label1.Text = cal.FAns.ToString();
            cal.number1 = (int)cal.FAns;
            cal.number2 = cal.FAns - cal.number1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.sign = 1;
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "+";
        }

        public void button6_Click(object sender, EventArgs e)
        {
            equalC = true;
            cal.zuhe();
            cal.doMath();
            dotBT.Enabled = true;
            cal.buff = "";
            cal.ans = cal.ANS;
            label1.Text = cal.ANS.ToString();
            cal.FAns = cal.ANS;
            dotBT.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.ANS = 0;
            cal.number2 = 0;
            cal.number1 = 0;
            cal.ans = 0;
            cal.buff = "";
            label1.Text = "";
            dotBT.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "/";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.number2 = 0;
            cal.number1 = 0;
            cal.ans = 0;
            label1.Text = "";
            dotBT.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            equalC = true;
            cal.zuhe();
            dotBT.Enabled = true;
            cal.FAns = 1 / cal.ans;
            cal.ANS = 1 / cal.ans;
            if (cal.ans != 0)
            {
                label1.Text = cal.ANS.ToString();
                cal.buff = "/";
            }
            else
            {
                MessageBox.Show("脑残啊，0有倒数的啊！！！");
                label1.Text = "0";
                cal.buff = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            equalC = true;
            cal.zuhe();
            dotBT.Enabled = true;
            if (cal.ans >= 0)
            {
                if (cal.ans > 0)
                {
                    cal.FAns = Math.Sqrt(cal.ans);
                    cal.ANS = Math.Sqrt(cal.ans);
                    label1.Text = "±" + cal.ANS.ToString();
                    cal.buff = "/";
                }
                else
                {
                    cal.FAns = Math.Sqrt(cal.ans);
                    cal.ANS = Math.Sqrt(cal.ans);
                    label1.Text = cal.ANS.ToString();
                    cal.buff = "/";
                }
            }
            else
            {
                MessageBox.Show("这里不搞复数运算。");
                label1.Text = "0";
                cal.buff = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "%";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "\\";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            equalC = true;
            cal.zuhe();
            dotBT.Enabled = true;

            if (cal.ans >= 0)
            {
                if (cal.ans == 0)
                {
                    cal.FAns = 1;
                    cal.ANS = 1;
                    label1.Text = "1";
                }
                else
                {
                    cal.ANS = 1;
                    for (int i = 1; i <= cal.ans; i++)
                    {
                        cal.ANS = cal.ANS * i;
                    }
                    cal.FAns = cal.ANS;
                    label1.Text = cal.ANS.ToString();
                }
            }
            else
            {
                MessageBox.Show("脑残啊，负数也有阶乘的啊！！！");
                label1.Text = "0";
                cal.buff = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.ANS = Math.Sin(cal.ans);
            cal.FAns = cal.ANS;
            label1.Text = cal.ANS.ToString();
            cal.buff = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.ANS = Math.Cos(cal.ans);
            cal.FAns = cal.ANS;
            label1.Text = cal.ANS.ToString();
            cal.buff = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.ANS = Math.Tan(cal.ans);
            cal.FAns = cal.ANS;
            label1.Text = cal.ANS.ToString();
            cal.buff = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            if (cal.ans <= 1 && cal.ans >= -1)
            {
                cal.ANS = Math.Asin(cal.ans);
                cal.FAns = cal.ANS;
                label1.Text = cal.ANS.ToString();
            }
            else
            {
                MessageBox.Show("脑残啊，连个定义域都不知道啊！！！");
                label1.Text = "0";
            }
            cal.buff = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            if (cal.ans <= 1 && cal.ans >= -1)
            {
                cal.ANS = Math.Acos(cal.ans);
                cal.FAns = cal.ANS;
                label1.Text = cal.ANS.ToString();
            }
            else
            {
                MessageBox.Show("脑残啊，连个定义域都不知道啊！！！");
                label1.Text = "0";
            }
            cal.buff = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.ANS = Math.Atan(cal.ans);
            cal.FAns = cal.ANS;
            label1.Text = cal.ANS.ToString();
            cal.buff = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            if (cal.ans > 0)
            {
                cal.ANS = Math.Log(cal.ans);
                cal.FAns = cal.ANS;
                label1.Text = cal.ANS.ToString();
            }
            else
            {
                MessageBox.Show("这里不搞复数情况！！！");
                label1.Text = "0";
            }
            cal.buff = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.ANS = cal.ans;
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "^";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.ANS = Math.Exp(cal.ans);
            cal.FAns = cal.ANS;
            label1.Text = cal.ANS.ToString();
            cal.buff = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
        }

        private void button26_Click(object sender, EventArgs e)
        {
        }

        private void button27_Click(object sender, EventArgs e)
        {
        }

        private void button28_Click(object sender, EventArgs e)
        {
        }

        private void 向量计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"强大的组件\\空间向量.exe"))
            {
                MessageBox.Show("你好像没有冰火向量计算器程序。");
            }
            else
            {
                Process.Start("强大的组件\\空间向量.exe");
            }
        }

        private void 解方程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"强大的组件\\解方程计算器.exe"))
            {
                MessageBox.Show("你好像没有冰火解方程计算器程序。");
            }
            else
            {
                Process.Start("强大的组件\\解方程计算器.exe");
            }
        }

        private void 解三角形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"强大的组件\\解三角形.exe"))
            {
                MessageBox.Show("你好像没有冰火解三角形程序。");
            }
            else
            {
                Process.Start("强大的组件\\解三角形.exe");
            }
        }

        private void 排列组合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"强大的组件\\排列组合运算.exe"))
            {
                MessageBox.Show("你好像没有冰火排列组合运算程序。");
            }
            else
            {
                Process.Start("强大的组件\\排列组合运算.exe");
            }
        }

        private void 空间直线及投影ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"强大的组件\\空间直线及其投影.exe"))
            {
                MessageBox.Show("你好像没有冰火空间直线及其投影程序。");
            }
            else
            {
                Process.Start("强大的组件\\空间直线及其投影.exe");
            }
        }

        private void 不同坐标系点的转化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"强大的组件\\不同坐标系点的转化.exe"))
            {
                MessageBox.Show("你好像没有冰火不同坐标系点的转化程序。");
            }
            else
            {
                Process.Start("强大的组件\\不同坐标系点的转化.exe");
            }
        }

        private void 关于计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本：2.0\r\n作者：冰火（Hypnos）\r\nQQ：601670314（用于BUG反馈。验证信息：C#程序资源BUG）\r\n本计算器有基本的算术功能和一些常用函数计算。部分语法如下：\r\n（1）三角函数，反三角函数，exp函数，ln函数：此类函数参数值优先输入，然后输函数名。例如要计算sin10的值，则应该先使用数字键输入10，然后点击sin按钮。\r\n（2）MOD函数：此函数先输入被除数，然后是函数名，最后是除数，输出余数。（3）log函数：例如输入顺序为4log2，代表：以2为底，4的对数。\r\n关于数学常数与ANS说明：点击常数或ANS，将消除原先输入的数字，并存放在ANS中。例如：输入：10e，那么实际数字为e，因为e把10给覆盖。如果需要计算10e，则要输入10×e，并且计算结果储存在ANS中。要使用10e，则点击ANS即可。\r\n关于清除命令：\r\nCl指令：清除运算符之后的输入内容。\r\nAC指令：全部清除。", "关于计算器");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            equalC = false;
            cal.zuhe();
            cal.FAns = Math.Log(cal.ans);
            cal.doMath();
            dotBT.Enabled = true;
            label1.Text = "";
            cal.buff = "log";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text = pi.ToString();
            cal.number1 = (int)pi;
            cal.number2 = pi - cal.number1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = ee.ToString();
            cal.number1 = (int)ee;
            cal.number2 = ee - cal.number1;
        }

        private void 高级功能说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("所有在本计算器使用的高级功能全部开源，并在冰火源码资源网址可以全数下载。使用高级功能，系统将检查是否在“强大的组件”文件夹中包含这些组件并运行。如果没有，则可以到冰火资源首页查找相应资源下载。网址在帮助中有，可以直接连接。（如果网页出现资源无法下载的情况，则可以百度一下，该资源被其他各种网页收录。为了确保质量，请使用正版软件）\r\n有关高级功能的使用方法不作其他详细解答。", "关于高级功能");
        }

        private void 百度官网ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe", "http://hi.baidu.com/冰火ice");
        }

        private void 冰火资源首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}