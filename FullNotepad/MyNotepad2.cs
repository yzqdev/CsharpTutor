using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace frmmain
{
public partial class MyNotepad2 : Form
{

    private string filename = ""; //保存文件名
    private Find frmsearch;
    private Replace frmrep;


    public MyNotepad2()
    {
        InitializeComponent();
        frmsearch = new Find(richTxt);

    }


    #region 文件菜单项功能代码

    private void OpenFile()  //打开函数
    {
        openFileDialog1.FileName = "*.txt";
        openFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件|*.*";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
            this.Text = Path.GetFileName(openFileDialog1.FileName) + " - MyNotepad2";
            richTxt.Text = sr.ReadToEnd();
            filename = openFileDialog1.FileName;
            sr.Close();

        }
    }

    private void textchanged(string filepath)//文字发生改变时,提示保存
    {
        DialogResult re = MessageBox.Show("文件 " + filepath + " 的内容已经更改" + "\r\n" + "想保存文件吗?", "MyNotepad2", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        switch (re)
        {
        case DialogResult.Yes:
        {
            if (filename == "")
            {
                saveFileDialog1.FileName = "*.txt";
                saveFileDialog1.Filter = "文本文档(*.txt)|*.txt";
                //saveFileDialog1.DefaultExt = "*.txt";
                saveFileDialog1.Title = "保存";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTxt.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = "无标题 - MyNotepad2";
                    richTxt.Clear();

                }

            }
            else
            {
                richTxt.SaveFile(filename, RichTextBoxStreamType.PlainText);
                this.Text = "无标题 - MyNotepad2";
                richTxt.Clear();

            }
            break;
        }


        case DialogResult.No:
        {
            richTxt.Text = "";
            this.Text = "无标题-MyNotepad2";
            break;
        }
        case DialogResult.Cancel:
        {
            break;
        }


        }
    }


    private void NewMenuItem_Click(object sender, EventArgs e) //新建
    {
        if (richTxt.Modified == true)
        {
            if (filename == "")
            {
                textchanged(this.Text.Substring(0, this.Text.LastIndexOf("-")));
            }
            else
            {
                textchanged(filename);
            }
        }
        else
        {
            richTxt.Text = "";
            this.Text = "无标题-MyNotepad2";
            filename = "";
        }
    }

    private void OpenMenuItem_Click(object sender, EventArgs e) //打开
    {
        if (richTxt.Modified == true)
        {
            if (filename == "")
            {
                DialogResult re = MessageBox.Show("文件 无标题 的文字已经更改" + "\r\n" + "想保存文件吗?", "MyNotepad2", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (re == DialogResult.Yes)
                {
                    AddsaveMenuItem_Click(sender, e);
                    OpenFile();
                }
                if (re == DialogResult.No)
                {
                    OpenFile();
                }
                if (re == DialogResult.Cancel)
                {
                    // return;
                }
            }
            else
            {
                DialogResult re = MessageBox.Show("文件 " + filename + " 的内容已经更改" + "\r\n" + "想保存文件吗?", "MyNotepad2", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (re == DialogResult.Yes)
                {
                    richTxt.SaveFile(filename, RichTextBoxStreamType.PlainText);
                    OpenFile();
                }
                if (re == DialogResult.No)
                {
                    OpenFile();
                }
                if (re == DialogResult.Cancel)
                {
                    //return;
                }
            }
        }
        else
        {
            OpenFile();

        }
    }

    private void SaveMenuItem_Click(object sender, EventArgs e) //保存
    {
        if (filename == "")
        {
            saveFileDialog1.FileName = "无标题.txt";
            saveFileDialog1.Filter = "文本文档(*.txt)|*.txt";
            //saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Title = "保存";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTxt.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText); //写入文本的实现,如果用Stream write,碰到回车只能显示黑点;
                richTxt.Modified = false;
                filename = saveFileDialog1.FileName;
                this.Text = Path.GetFileName(saveFileDialog1.FileName) + " - MyNotepad2";

            }

        }
        else
        {
            richTxt.SaveFile(filename, RichTextBoxStreamType.PlainText);
            // StreamWriter sw = new StreamWriter(filename, false, Encoding.Default);
            //sw.Write(richTxt.Text);
            //sw.Close();
            richTxt.Modified = false;
        }
    }

    private void AddsaveMenuItem_Click(object sender, EventArgs e) //另存为
    {
        saveFileDialog1.FileName = "*.txt";
        saveFileDialog1.Filter = "文本文档(*.txt)|*.txt";
        // saveFileDialog1.DefaultExt = "*.txt";
        saveFileDialog1.Title = "另存为";
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            richTxt.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            filename = saveFileDialog1.FileName;
            this.Text = Path.GetFileName(saveFileDialog1.FileName) + " - MyNotepad2";
        }
    }

    private void PageMenuItem_Click(object sender, EventArgs e) //页面设置
    {
        this.pageSetupDialog1.Document = printDocument1;
        try
        {
            pageSetupDialog1.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void PrintMenuItem_Click(object sender, EventArgs e) //打印
    {
        if (printDialog1.ShowDialog() == DialogResult.OK)
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "打印错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

    private void ExitMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (richTxt.Modified == true)
        {
            if (filename == "")
            {
                DialogResult re = MessageBox.Show("文件 无标题 的文字已经改变" + "\r\n" + "想保存文件吗?", "MyNotepad2", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (re)
                {
                case DialogResult.Yes:
                {
                    this.SaveMenuItem_Click(sender, e);
                    if (richTxt.Modified == true)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                        //Application.Exit();
                    }


                    break;
                }
                case DialogResult.No:
                {
                    e.Cancel = false;
                    break;
                }
                case DialogResult.Cancel:
                {
                    e.Cancel = true;
                    break;
                }
                }
            }
            else
            {
                DialogResult re = MessageBox.Show("文件 " + filename + " 的文字已经改变" + "\r\n" + "想保存文件吗?", "MyNotepad2", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (re)
                {
                case DialogResult.Yes:
                {
                    this.SaveMenuItem_Click(sender, e);
                    if (richTxt.Modified == true)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Application.Exit();
                    }

                    break;
                }
                case DialogResult.No:
                    e.Cancel = false;
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

                }



            }
        }
    }
    #endregion




    private void EditMenuItem_DropDownOpened(object sender, EventArgs e) //下拉编辑栏时,各子按钮的可用性
    {
        if (richTxt.CanUndo == true)
        {
            UndoMenuItem.Enabled = true;
        }
        else
        {
            UndoMenuItem.Enabled = false;
        }
        if (richTxt.SelectedText.Length > 0)
        {
            CutMenuItem.Enabled = true;
            CopyMenuItem.Enabled = true;
            DelMenuItem.Enabled = true;
        }
        else
        {
            CutMenuItem.Enabled = false;
            CopyMenuItem.Enabled = false;
            DelMenuItem.Enabled = false;
        }
        if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
        {
            PasteMenuItem.Enabled = true;
        }
        else
        {
            PasteMenuItem.Enabled = false;
        }
        if (richTxt.Text.Length > 0)
        {
            FindMenuItem.Enabled = true;
            FindNextItem.Enabled = true;
        }
        else
        {
            FindMenuItem.Enabled = false;
            FindNextItem.Enabled = false;
        }
        if (!NewLineMenuItem.Checked)
        {
            GotoMenuItem.Enabled = true;

        }
        else
        {
            GotoMenuItem.Enabled = false;
        }
    }


    private void UndoMenuItem_Click(object sender, EventArgs e) //撤消按钮
    {
        this.richTxt.Undo();
        //this.richTxt.ClearUndo(); //有了这句只能撤消一步
    }

    private void CutMenuItem_Click(object sender, EventArgs e) //剪切
    {
        this.richTxt.Cut();
    }

    private void CopyMenuItem_Click(object sender, EventArgs e) //复制
    {
        this.richTxt.Copy();
    }

    private void PasteMenuItem_Click(object sender, EventArgs e) //粘贴
    {
        this.richTxt.Paste();
    }

    private void DelMenuItem_Click(object sender, EventArgs e) //删除
    {
        this.richTxt.SelectedText = "";  //其实这个按钮功能可以不用写,写了反而不能删除光标后的那个字符了

    }


    private void FindMenuItem_Click(object sender, EventArgs e) //查找
    {

        frmsearch.Show(this);//等同于frmsearch.Owner = this; frmsearch.show()两句
        frmsearch.Top = this.Top + 200;
        frmsearch.Left = this.Left + 5;

        // f .Show(this);
    }

    private void FindNextItem_Click(object sender, EventArgs e)  //查找下一个
    {

        if (frmsearch.flag)
        {
            frmsearch.btnNext_Click(sender, e);
        }
        else
        {
            FindMenuItem_Click(sender, e);
        }

    }

    private void ReplaceMenuItem_Click(object sender, EventArgs e) //替换
    {
        frmrep = new Replace(richTxt);
        frmrep.Show(this);
        frmrep.Top = this.Top + 200;
        frmrep.Left = this.Left + 5;
    }

    private void GotoMenuItem_Click(object sender, EventArgs e) //转到
    {
        new Goto(richTxt).ShowDialog();
    }

    private void SelectAllMenuItem_Click(object sender, EventArgs e) //全选
    {
        this.richTxt.SelectAll();
    }

    private void DateTimeMenuItem_Click(object sender, EventArgs e) //时间/日期
    {
        this.richTxt.AppendText(DateTime.Now.ToString()); //文本末尾追加文本
    }


    private void ViewMenuItem_DropDownOpened(object sender, EventArgs e) //下拉查看按钮时发生
    {
        if (!NewLineMenuItem.Checked)
            StatusMenuItem.Enabled = true;
        else
            StatusMenuItem.Enabled = false;
    }

    private void NewLineMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        if (!NewLineMenuItem.Checked)
        {
            richTxt.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTxt.WordWrap = false;
        }
        else
        {
            richTxt.WordWrap = true;
        }
    }

    private void NewLineMenuItem_Click(object sender, EventArgs e)
    {
        NewLineMenuItem.Checked = !NewLineMenuItem.Checked;
        if (NewLineMenuItem.Checked)
        {
            GotoMenuItem.Enabled = false;
            StatusMenuItem.Enabled = false;
            richTxt.Height = this.Height - 58;
            StatusMenuItem.Checked = false;
            statusStrip1.Visible = false;

        }
        else
        {
            GotoMenuItem.Enabled = true;
            StatusMenuItem.Enabled = true;

        }
    }

    private void FontMenuItem_Click(object sender, EventArgs e)
    {
        if (fontDialog1.ShowDialog() == DialogResult.OK)
        {
            richTxt.Font = fontDialog1.Font;
            richTxt.ForeColor = fontDialog1.Color;
        }
    }

    private void StatusMenuItem_Click(object sender, EventArgs e)
    {
        StatusMenuItem.Checked = !StatusMenuItem.Checked;
        if (StatusMenuItem.Checked)
        {
            statusStrip1.Visible = true;
            richTxt.Height = this.Height - 83;
        }
        else
        {
            statusStrip1.Visible = false;
            richTxt.Height = this.Height - 58;
        }
    }

    private void status()
    {

        int start = 0;
        int cursor = richTxt.SelectionStart;
        int line = richTxt.GetLineFromCharIndex(cursor);
        while (start < cursor)
        {
            if (richTxt.GetLineFromCharIndex(start) != line)
            {
                start++;
            }
            else break;
        }
        int col = cursor - start + 1;
        line++;
        toolStripStatusLabel1.Text = statusStrip1.Text = "line " + line + ",col " + col;
    }

    private void richTxt_SelectionChanged(object sender, EventArgs e)
    {
        status();
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
        if (richTxt.CanUndo == true)
        {
            Undo1MenuItem.Enabled = true;
        }
        else
        {
            Undo1MenuItem.Enabled = false;
        }
        if (richTxt.SelectedText.Length > 0)
        {
            Cut1MenuItem.Enabled = true;
            Copy1MenuItem.Enabled = true;
            Del1MenuItem.Enabled = true;
        }
        else
        {
            Cut1MenuItem.Enabled = false;
            Copy1MenuItem.Enabled = false;
            Del1MenuItem.Enabled = false;
        }
        if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
        {
            Paste1MenuItem.Enabled = true;
        }
        else
        {
            Paste1MenuItem.Enabled = false;
        }

    }

    #region 右键菜单
    private void Undo1MenuItem_Click(object sender, EventArgs e)
    {
        this.richTxt.Undo();
    }

    private void Cut1MenuItem_Click(object sender, EventArgs e)
    {
        this.richTxt.Cut();
    }

    private void Copy1MenuItem_Click(object sender, EventArgs e)
    {
        this.richTxt.Copy();
    }

    private void Paste1MenuItem_Click(object sender, EventArgs e)
    {
        this.richTxt.Paste();
    }

    private void Del1MenuItem_Click(object sender, EventArgs e)
    {
        this.richTxt.SelectedText = "";
    }

    private void SelectAll1MenuItem_Click(object sender, EventArgs e)
    {
        this.richTxt.SelectAll();
    }

    #endregion



    private void AboutMenuItem_Click(object sender, EventArgs e)  //关于MyNotepad2
    {
        About frm = new About();
        frm.ShowDialog(this);
    }




}
}
