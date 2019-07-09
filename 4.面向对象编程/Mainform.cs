using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csconsoletest2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private Methodtest md = new Methodtest();

        private void button1_Click(object sender, EventArgs e)
        {
            Zhangsannianling z = new Zhangsannianling();
            z.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            md.calcarea();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            md.Sfruit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            md.coll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            md.student();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            md.vehicle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            md.showinfostu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            md.itstuteach();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            md.icalculate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            md.showchieng();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            md.showemployee();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            md.showsealedclass();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            md.diedai();
        }
    }
}