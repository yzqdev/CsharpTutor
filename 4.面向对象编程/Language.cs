using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csconsoletest2
{
    public partial class Language : Form
    {
        public Language()
        {
            InitializeComponent();
        }

        private void Language_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("不想对友人说点什么吗？", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (CheckChi(textBox1.Text))
                    {
                        ISelectLang iselect = new SpeakChi();
                        iselect.Speak(textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("请和中国人说汉语", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (CheckChi(textBox1.Text))
                    {
                        MessageBox.Show("请和美国人说英语", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        ISelectLang iselect = new SpeakEng();
                        iselect.Speak(textBox1.Text);
                    }
                }
            }
        }

        private bool CheckChi(string str)
        {
            bool flag = false;
            UnicodeEncoding a = new UnicodeEncoding();
            byte[] b = a.GetBytes(str);
            for (int i = 0; i < b.Length; i++)
            {
                i++;
                if (b[i] != 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}

internal interface ISelectLang
{
    void Speak(string str);
}

internal class SpeakChi : ISelectLang
{
    public void Speak(string str)
    {
        MessageBox.Show("您对中国友人说" + str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

internal class SpeakEng : ISelectLang
{
    public void Speak(string str)
    {
        MessageBox.Show("您对美国友人说" + str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}