using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csconsoletest2
{
    public partial class Zhangsannianling : Form
    {
        public Zhangsannianling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person p = new Person();
                //if (bool.Parse(p.setName(textBox1.Text)))
                //{
                //    p.setName(textBox1.Text);
                //}
                //else
                //{
                //    MessageBox.Show("请输入名字！");
                //}
                if (p.setAge(Convert.ToInt16(textBox2.Text)))
                {
                    p.sayAge();
                }
                else
                {
                    MessageBox.Show("输入的年龄不在1~120之间");
                }
            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入姓名！");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("请输入年龄！");
                }
            }
        }
    }

    public class Person : Zhangsannianling
    {
        public string name;
        private int age;

        public void sayAge()
        {
            MessageBox.Show("I am " + age.ToString() + " years old");
        }

        public Boolean setAge(int a)
        {
            if (a > 0 && a <= 120)
            {
                age = a;
                return true;
            }
            else
            {
                return false;
            }
        }

        //public string setName(string name)
        //{
        //    return name;
        //}
    }
}