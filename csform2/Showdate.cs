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
    public partial class Showdate : Form
    {
        public Showdate()
        {
            InitializeComponent();
        }

        private enum Week
        { 星期日, 星期一, 星期二, 星期三, 星期四, 星期五, 星期六 };

        private void Showdate_Load(object sender, EventArgs e)
        {
            Week today = Week.星期日;
            today = (Week)DateTime.Now.DayOfWeek;
            label1.Text = "今天是" + DateTime.Now.Date.ToShortDateString() + "" + today;
        }
    }
}