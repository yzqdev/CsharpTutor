using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var names = new List<string> { "name", "anna", "felipe" };
            names.Add("Bill");
            names.Sort();

            foreach (var name in names)
            {
                textBox1.AppendText($"hello{name.ToUpper()}");
            }
            label1.Text = names.Count().ToString();
        }
    }
}