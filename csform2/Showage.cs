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
    public partial class Showage : Form
    {
        private struct Student
        {
            public string stuID;
            public string stuName;
            public string stuSex;
            public byte stuAge;
            public string stuProvince;
        }

        public Showage()
        {
            InitializeComponent();
        }

        private void Showage_Load(object sender, EventArgs e)
        {
            Student stu;
            stu.stuID = "3434343434";
            stu.stuName = "安娜";
            stu.stuSex = "女";
            stu.stuAge = 18;
            stu.stuProvince = "北京";
            label1.Text = stu.stuName + "的年龄是" + Convert.ToString(stu.stuAge) + ",籍贯是" + stu.stuProvince;
        }
    }
}