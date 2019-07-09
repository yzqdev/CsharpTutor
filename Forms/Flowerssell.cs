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
    public partial class Flowerssell : Form
    {
        public Flowerssell()
        {
            InitializeComponent();
        }

        //通过数组可以记录5中不同的鲜花
        public Flowers[] f = new Flowers[5];

        //记录已经录入的鲜花个数
        private int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();
                string location = textBox1.Text.Trim();
                double price = double.Parse(textBox3.Text.Trim());
                int num = int.Parse(textBox4.Text.Trim());
                if (i < 5)
                {
                    f[i] = new Flowers(name, location, price);
                    f[i].add(num);
                    MessageBox.Show("录入成功!");
                }
                else
                {
                    MessageBox.Show("只能储存5种鲜花的信息!");
                }
                i++;
                //录入一种鲜花信息成功后清空录入信息内容便于下次录入
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.Focus();
            }
            catch (Exception a)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请输入名称!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("请输入产地!");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("请输入价格!");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("请输入数量!");
                }
                //MessageBox.Show(a.Message);
                //MessageBox.Show("请输入!");
            }
        }

        /// <summary>
        /// 在录入界面租后一个txtbox控件中按回车键就可以实现信息录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }//用户在tebcontrol控件的不同tabpage之间切换时,根据tebpage的索引值判断用户进入了哪一个tabpage并执行相应的操作

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //用户进入"销售鲜花"
            if (tabControl1.SelectedIndex == 1)
            {
                comboBox1.Items.Clear();
                for (int i = 0; i < Flowers.Type_num; i++)
                {
                    comboBox1.Items.Add(f[i].Name);
                }
            }
            //用户进入"库存管理"
            if (tabControl1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < Flowers.Type_num; i++)
                {
                    comboBox2.Items.Add(f[i].Name);
                }
            }
        }

        /// <summary>
        /// 将鲜花数量显示在label中便与销售
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for (int i = 0; i < Flowers.Type_num; i++)
            {
                if (comboBox1.Text == f[i].Name)
                {
                    lb_nownum.Text += f[i].Num.ToString();
                }
            }
        }

        /// <summary>
        /// 根据用户选中的鲜花名称,在文本框中写入销售数量,销售鲜花
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Flowers.Type_num; i++)
            {
                if (comboBox1.Text == f[i].Name)
                {
                    f[i].reduce(int.Parse(textBox5.Text));
                    MessageBox.Show("成功销售了" + textBox5.Text + "朵" + f[i].Name);
                }
            }
        }

        /// <summary>
        /// 根据用户选中的鲜花名称,将鲜花信息显示在textbox中便于修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Flowers.Type_num; i++)
            {
                if (comboBox2.Text == f[i].Name)
                {
                    text_location.Text = f[i].Location;
                    text_price.Text = f[i].Price.ToString();
                    text_num.Text = f[i].Name.ToString();
                }
            }
        }

        /// <summary>
        /// 根据用户的选择的鲜花名称在文本框里下乳的产地,价格,数量修改原有鲜花的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Flowers.Type_num; i++)
            {
                if (comboBox2.Text == f[i].Name)
                {
                    f[i].Location = text_location.Text.Trim();
                    f[i].Price = double.Parse(text_price.Text.Trim());
                    f[i].Num = int.Parse(text_num.Text.Trim());
                    MessageBox.Show("更改成功!");
                }
            }
        }
    }
}