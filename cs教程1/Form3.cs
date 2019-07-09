using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csTest1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string pass = textPassw.Text.Trim();
            if (rdoStu.Checked || rdoTeach.Checked)
            {
                if (rdoStu.Checked)
                {
                    if (name == "student" && pass == "student")
                    {
                        MessageBox.Show("学生登录成功!");
                    }
                    else
                    {
                        MessageBox.Show("学生登录失败!");
                        textName.Clear();
                        textPassw.Clear();
                        textName.Focus();
                    }
                }
                else if (rdoTeach.Checked)
                {
                    if (name == "teacher" && pass == "teacher")
                    {
                        MessageBox.Show("老师登录成功!");
                    }
                    else
                    {
                        MessageBox.Show("老师登录失败!");
                        textName.Clear();
                        textPassw.Clear();
                        textName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("请选择登录身份!");
                }
            }
            else
            {
                MessageBox.Show("请选择登录身份!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browser brower = new Browser();
            brower.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //通过进程打开一些工具
            Process.Start("calc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("nTrun");
            }
            catch
            {
                Process.Start("start");
            }
            finally
            {
                //Process.Start("cmd");
                ProcessStartInfo psi = new ProcessStartInfo(@"C:\Windows\notepad.exe");
                Process pr = new Process();
                pr.StartInfo = psi;
                pr.Start();
            }
        }
    }
}