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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Showorhide form1 = new Showorhide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Property pro = new Property();
            pro.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Submittest submit = new Submittest();
            submit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Listbox listbox = new Listbox();
            listbox.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Comboboxtest com = new Comboboxtest();
            com.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Listviewtest lvt = new Listviewtest();
            lvt.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Datetim datetim = new Datetim();
            datetim.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tabcontrol tcontrol = new Tabcontrol();
            tcontrol.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Timertest timer = new Timertest();
            timer.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Flowerssell flower = new Flowerssell();
            flower.Show();
        }
    }
}