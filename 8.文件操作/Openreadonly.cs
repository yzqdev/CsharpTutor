using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.文件操作
{
    public partial class Openreadonly : Form
    {
        public Openreadonly()
        {
            InitializeComponent();
        }

        private void Openreadonly_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = File.OpenText("D:\\test.txt"))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        label1.Text = s;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("文件不存在！是否创建？", "提示", MessageBoxButtons.OKCancel); Creatfile cf = new Creatfile();
                cf.creattxt();
                cf.creatimg();
                Openfiletest of = new Openfiletest();
                of.opentxt();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creatfile cf = new Creatfile();
            cf.creattxt();
            cf.creatimg();
            Openfiletest of = new Openfiletest();
            of.opentxt();
        }
    }
}