using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csform2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showage showage = new Showage();
            showage.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arrayli arrayli = new Arrayli();
            arrayli.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Showdate showdate = new Showdate();
            showdate.Visible = true;
            //showdate.BackColor = red;
        }
    }
}