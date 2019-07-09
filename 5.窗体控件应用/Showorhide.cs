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
    public partial class Showorhide : Form
    {
        public Showorhide()
        {
            InitializeComponent();
        }

        private Hideform hideform = new Hideform();

        private void button1_Click(object sender, EventArgs e)
        {
            hideform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideform.Hide();
        }
    }
}