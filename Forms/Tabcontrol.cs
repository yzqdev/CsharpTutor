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
    public partial class Tabcontrol : Form
    {
        public Tabcontrol()
        {
            InitializeComponent();
        }

        private Employee[] purchas_depat1 = new Employee[4];//定义employee数组二村方采购部第一课的员工信息

        private void Tabcontrol_Load(object sender, EventArgs e)
        {
            purchas_depat1[0] = new Employee("杨运辉", "男", 19, "河南郑州", "18856878777");
            purchas_depat1[1] = new Employee("陈中亮", "男", 21, "湖南庐江", "18856876777");
            purchas_depat1[2] = new Employee("郑宇鹏", "女", 20, "广西桂林", "18866232888");
            purchas_depat1[3] = new Employee("杨正谦", "男", 19, "河南南阳", "18856967709");
            foreach (Employee s in purchas_depat1)
            {
                s.Info = "姓名是:" + s.Name;
                s.Info += "\n性别是:" + s.Sex;
                s.Info += "\n年龄是:" + s.Age;
                s.Info += "\n籍贯是:" + s.Native_place;
                s.Info += "\n电话是:" + s.Tel;
            }
            purchas_depat1[0].Info += "\n工作经历:\n2015-2017:公司后勤部;\n2010-2014:公司技术部\n2007-2010:外出进修\n2005-2007:公司采购部";
            purchas_depat1[1].Info += "\n工作经历:\n2015-2017:公司后勤部;\n2010-2014:公司技术部\n2007-2010:外出进修\n2005-2007:公司采购部";
            purchas_depat1[2].Info += "\n工作经历:\n2015-2017:公司后勤部;\n2010-2014:公司技术部\n2007-2010:外出进修\n2005-2007:公司采购部";
            purchas_depat1[3].Info += "\n工作经历:\n2015-2017:公司后勤部;\n2010-2014:公司技术部\n2007-2010:外出进修\n2005-2007:公司采购部";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool flag = false;
            int i = 0;
            Employee s = new Employee();
            for (i = 0; i < 4; i++)
            {
                s = purchas_depat1[i];
                if (s.Name == e.Node.Text)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                textBox1.Text = s.Name;
                textBox2.Text = s.Sex;
                textBox3.Text = s.Age.ToString();
                textBox4.Text = s.Native_place;
                textBox5.Text = s.Tel;
                richTextBox1.Text = s.Info;
            }
        }
    }
}