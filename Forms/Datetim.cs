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
    public partial class Datetim : Form
    {
        public Datetim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.TodayDate = dateTimePicker1.Value;
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }
    }
}