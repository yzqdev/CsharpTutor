using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csTest1
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// 显示窗口的方法
        /// </summary>
        /// <returns></returns>
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 显示button2单击方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Location = new Point(400, 400);
        }
    }
}