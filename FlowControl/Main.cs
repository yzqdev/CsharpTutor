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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            pass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Switcht switcht = new Switcht();
            switcht.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fortest fortest = new Fortest();
            fortest.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Whiletest whiletest = new Whiletest();
            whiletest.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shuixianhua shui = new Shuixianhua();
            shui.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Breaktest breaktest = new Breaktest();
            breaktest.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wanshutest wanshu = new Wanshutest();
            wanshu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Yuefen yufen = new Yuefen();
            yufen.Show();
        }
    }
}