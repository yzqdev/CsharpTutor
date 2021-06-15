using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmmain
{

    public partial class Find : Form
    {
        //下载于www.mycodes.net
        private System.Windows.Forms.RichTextBox richTxt;
        public bool flag = false;
        public Find(System.Windows.Forms.RichTextBox richTxt)
        {
            InitializeComponent();
            this.richTxt = richTxt;
        }

        private int start = 0;

        public void btnNext_Click(object sender, EventArgs e)
        {
            if (radioDown.Checked) //向下查找
            {
                start = checkCase.Checked ? richTxt.Text.IndexOf(Txtfind.Text, start, richTxt.Text.Length - start, StringComparison.CurrentCulture) : richTxt.Text.IndexOf(Txtfind.Text, start, richTxt.Text.Length - start, StringComparison.CurrentCultureIgnoreCase);
                //start = checkCase.Checked ? richTxt.Find(Txtfind.Text, start, richTxt.Text.Length, RichTextBoxFinds.MatchCase) : richTxt.Find(Txtfind.Text, start, richTxt.Text.Length, RichTextBoxFinds.None);

                if (start != -1)
                {
                    richTxt.Select(start, Txtfind.Text.Length);
                    start += Txtfind.Text.Length;
                    richTxt.Focus();
                }
                else
                {
                    MessageBox.Show("已到文件末尾!");
                    start = 0;
                }
            }
            else  //向上查找
            {
                start = checkCase.Checked ? richTxt.Find(Txtfind.Text, 0, start, RichTextBoxFinds.MatchCase | RichTextBoxFinds.Reverse) : richTxt.Find(Txtfind.Text, 0, start, RichTextBoxFinds.Reverse);
                if (start != -1)
                {

                    richTxt.Select(start, Txtfind.Text.Length);
                    richTxt.Focus();
                }
                else
                {
                    MessageBox.Show("已到文件末尾!");

                }
            }
            flag = true;
        }


        private void Txtfind_TextChanged(object sender, EventArgs e) //查找内容为空,则查找下一个按钮不可用
        {
            if (Txtfind.Text == "")
            {
                btnNext.Enabled = false;
            }
            else btnNext.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void FrmFind_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner = null; //这句十分重要,如果不加,打开一个文本后查找,再关闭查找按钮后,窗口不能关闭;
            e.Cancel = true;
            this.Hide();
        }

    }
}