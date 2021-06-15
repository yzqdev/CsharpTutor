using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//www.srcfans.com
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Hide();
            this.Visible = false;
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            FrmMain fff = new FrmMain();
            fff.Show();
            
        }
    }
}
