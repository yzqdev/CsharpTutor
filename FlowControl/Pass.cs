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
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 8) && (textBox1.Text == "11111111"))
            {
                MessageBox.Show("密码正确!", "欢迎");
            }
            else
            {
                MessageBox.Show("输入错误,请输入八位密码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
    }
}