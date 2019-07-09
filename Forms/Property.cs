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
    public partial class Property : Form
    {
        public Property()
        {
            InitializeComponent();
        }

        private void Property_Load(object sender, EventArgs e)
        {
            this.Text = "可变化的窗体";
            this.Width = 600;
            this.Height = 800;
            this.BackColor = Color.Beige;
        }

        private void Property_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void Property_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭当前窗口?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}