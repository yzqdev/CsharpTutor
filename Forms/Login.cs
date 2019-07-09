using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private int i = 0;//记录输入错误的次数

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("密码不能为空", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if ((textBox1.Text == "root") && (textBox2.Text == "toor"))
            {
                MessageBox.Show("登录成功!", "提示", MessageBoxButtons.OKCancel);
            }
            else
            {
                i++;//输入错误,则i加一;
                MessageBox.Show("用户名或者密码错误,请重新输入", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (i >= 3)
                {
                    MessageBox.Show("连续三次错误,程序退出!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// 点击键盘实现登录效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}