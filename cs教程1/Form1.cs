using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你呦~");
        }

        private void Unlikebtn_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - Unlikebtn.Width;
            int y = this.ClientSize.Height - Unlikebtn.Height;
            Random random = new Random();
            Unlikebtn.Location = new Point(random.Next(0, x + 1), random.Next(0, y + 1));
        }

        private void Unlikebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不管怎样,我也爱你呦~");
        }

        private void Likebtn_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你呦~");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            paomadneglable.Text = paomadneglable.Text.Substring(1) + paomadneglable.Text.Substring(0, 1);
            // MessageBox.Show("我也爱你呦~");
        }

        /// <summary>
        /// 把当前时间装换为字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            if (DateTime.Now.Hour == 22 && DateTime.Now.Minute == 46 && DateTime.Now.Second == 11)
            {
                //播放音乐
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"D:\Desktop\Login.wav";
                sp.Play();
            }
        }

        /// <summary>
        /// 第一秒在窗口load时就把label上的文字变成当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process[] pros = Process.GetProcesses();
            foreach (var item in pros)
            {
                //item.Kill();
                string pro = item.ToString();
                textBox1.Text = pro;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Newform newform2 = new Newform();
            newform2.Showform2();
        }
    }
}