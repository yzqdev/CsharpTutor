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
    public partial class Comboboxtest : Form
    {
        public Comboboxtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = "院系信息是\n";
            info += comboBox1.Text + ",";
            info += comboBox2.Text + ",";
            info += comboBox3.Text + ",";
            MessageBox.Show(info, "院系信息");
        }
    }
}