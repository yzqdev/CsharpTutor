using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 编辑EToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 格式OToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 查看VToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 重做ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 剪切ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 粘贴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily f in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(f.Name);
            }
            for (int i = 8; i <= 72; i += 2)
            {
                toolStripComboBox2.Items.Add(i.ToString());
            }
            toolStripComboBox1.SelectedIndex = toolStripComboBox1.FindString("Microsoft YaHei UI");
            toolStripComboBox2.SelectedIndex = 1;
            string[] wdstr = new string[] { "日", "一", "二", "三", "四", "五", "六" };
            int wd = (int)DateTime.Now.DayOfWeek;
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString() + "星期" + wdstr[wd] + DateTime.Now.ToShortDateString();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}