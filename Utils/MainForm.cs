using System;
using System.Windows.Forms;

namespace Utils
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CantCatchme cantcatchme = new CantCatchme();
            cantcatchme.Visible = true;
        }

        private void Mouseposition_Click(object sender, EventArgs e)
        {
            MousePosition mousePositioin = new MousePosition();
            mousePositioin.Visible = true;
        }

        private void Getfilestyle_Click(object sender, EventArgs e)
        {
            GetFileStyle getFileStyle = new GetFileStyle();
            getFileStyle.Show();
        }
    }
}