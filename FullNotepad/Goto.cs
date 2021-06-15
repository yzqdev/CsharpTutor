using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmmain
{
    public partial class Goto : Form
    {
        private System.Windows.Forms.RichTextBox richTxt;//申明richTxt
        public Goto()
        {
            InitializeComponent();
        }
        public Goto(System.Windows.Forms.RichTextBox richTxt)
        {
            InitializeComponent();
            this.richTxt = richTxt;
            txtline.Text = (richTxt.GetLineFromCharIndex(richTxt.SelectionStart) + 1).ToString();
        }

        private bool isnumber(string txt) //判断数字函数
        {
            bool isnum = true;
            foreach (char ch in txt)
            {
                if (!char.IsNumber(ch))
                {

                    isnum = false;
                    break;
                }
                else
                {
                    isnum = true;
                }
            }
            return isnum;

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (isnumber(txtline.Text)) //如果输入的是数字
            {
                try
                {
                    int line = int.Parse(txtline.Text);
                    if (line == 0 || line > richTxt.GetLineFromCharIndex(richTxt.Text.Length) + 1)
                    {
                        MessageBox.Show("行数超出范围");
                        txtline.Text = (richTxt.GetLineFromCharIndex(richTxt.SelectionStart) + 1).ToString();
                        txtline.SelectAll();
                        txtline.Focus();
                    }
                    else
                    {
                        int start = 0;
                        while (start < richTxt.Text.Length)
                        {
                            if ((richTxt.GetLineFromCharIndex(start)) == line - 1)

                                break;
                            start++;
                        }
                        richTxt.Select(start, 0);
                        richTxt.Focus();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}