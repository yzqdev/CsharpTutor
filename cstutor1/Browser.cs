using System;
using System.Windows.Forms;

namespace csTest1
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Uri uri = new Uri("http://" + text);
            webBrowser1.Url = uri;
        }
    }
}