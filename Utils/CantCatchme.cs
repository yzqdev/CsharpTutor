using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public partial class CantCatchme : Form
    {
        public CantCatchme()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你简直是个住!", "我是猪");
            Console.Write("hellllllll");
        }

        private void Button1_DragEnter(object sender, DragEventArgs e)
        {
            int x = this.ClientSize.Width - button1.Width;
            int y = this.ClientSize.Height - button1.Height;
            Random random = new Random();
            button1.Location = new Point(random.Next(0, x + 1), random.Next(0, y + 1));
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = this.ClientSize.Width - button1.Width;
            int y = this.ClientSize.Height - button1.Height;
            Random random = new Random();
            button1.Location = new Point(random.Next(0, x + 1), random.Next(0, y + 1));
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - button1.Width;
            int y = this.ClientSize.Height - button1.Height;
            Random random = new Random();
            button1.Location = new Point(random.Next(0, x + 1), random.Next(0, y + 1));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你简直是个填充/a", "我是猪");
            Console.Write("hellllllll");
        }
    }
}