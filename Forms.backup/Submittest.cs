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
    public partial class Submittest : Form
    {
        public Submittest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info;
            string hobby = "";
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("名字不能为空");
                textBox1.Focus();
                return;
            }
            info = "姓名" + textBox1.Text.Trim() + ",性别";
            if (radioButton1.Checked)
            {
                info += radioButton1.Text;
            }
            else
            {
                info += radioButton2.Text;
            }
            foreach (CheckBox c in groupBox1.Controls)
            {
                if (c.Checked)
                {
                    hobby += "<" + c.Text + ">";
                }
            }
            if (hobby != "")
            {
                info += "\n爱好是:" + hobby;
            }
            else
            {
                info += "\n无特殊爱好";
            }
            MessageBox.Show(info, "信息确认");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton2.Checked = true;
            foreach (CheckBox c in groupBox1.Controls)
            {
                c.Checked = false;
            }
            textBox1.Focus();
        }
    }
}