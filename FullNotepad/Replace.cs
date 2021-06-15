using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmmain
{
    public partial class Replace : Form
    {
        private RichTextBox richTxt;
        MyNotepad2 frmmain = new MyNotepad2();
        public Replace()
        {
            InitializeComponent();
        }

        public Replace(RichTextBox richTxt)
        {
            InitializeComponent();
            this.richTxt = richTxt;
        }
        private int start = 0;
        private bool search(bool shownotfind)     //查找函数
        {
            bool find = true;
            start = checkCase.Checked ? richTxt.Text.IndexOf(txtSearch.Text, start, richTxt.Text.Length - start, StringComparison.CurrentCulture) : richTxt.Text.IndexOf(txtSearch.Text, start, richTxt.Text.Length - start, StringComparison.CurrentCultureIgnoreCase);
            //start = checkCase.Checked ? richTxt.Find(txtSearch.Text, start, richTxt.Text.Length, RichTextBoxFinds.MatchCase) : richTxt.Find(txtSearch.Text, start, richTxt.Text.Length, RichTextBoxFinds.None);
            //下载于www.mycodes.net
            if (start != -1)
            {
                richTxt.Select(start, txtSearch.Text.Length);
                start += txtSearch.Text.Length;
                richTxt.Focus();
            }
            else
            {
                if (shownotfind)
                {
                    MessageBox.Show("已到文件末尾!");
                    start = 0;
                }
                find = false;
            }
            return find;

        }





        public void btnSearch_Click(object sender, EventArgs e)
        {
            search(true);
        }



        private void btnReplace_Click(object sender, EventArgs e) //替换
        {

            if (richTxt.SelectedText.Length > 0)
            {
                richTxt.SelectedText = txtReplace.Text;
            }
            search(true);
        }


        private void btnReplaceAll_Click(object sender, EventArgs e) //替换全部
        {

            richTxt.Text = richTxt.Text.Replace(txtSearch.Text, txtReplace.Text); //自带的Replace函数,可以省略很多代码
            richTxt.Modified = true; //Replace函数替换后,默认文本中的内容没有变化,应该是一个BUG,所以加上这句,才能提醒保存
                                     /*
                                     while (search(false))
                                     {
                                         if (richTxt.SelectedText.Length > 0)
                                         {
                                             richTxt.SelectedText = txtReplace.Text;
                                         }
                                     }
                                     start = 0;
                                     */
                                     //下载于www.mycodes.net

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmreplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner = null; //重要,参见FrmFind.cs
            e.Cancel = true;
            this.Hide();
        }

    }
}