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
    public partial class Listviewtest : Form
    {
        public Listviewtest()
        {
            InitializeComponent();
        }

        private void Listviewtest_Load(object sender, EventArgs e)
        {
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "列标题1";
            ch.Width = 120;
            ch.TextAlign = HorizontalAlignment.Left;
            this.listView1.Columns.Add(ch);
            this.listView1.Columns.Add("列标题2", 120, HorizontalAlignment.Left); this.listView1.Columns.Add("列标题3", 120, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.View = View.Details;
            this.listView1.BeginUpdate();

            for (int i = 0; i < 9; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "Item" + i;

                lvi.SubItems.Add("第2列,第" + i + "行");
                lvi.SubItems.Add("第3列,第" + i + "行");
                this.listView1.Items.Add(lvi);
            }
            this.listView1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.View = View.LargeIcon;
            this.listView1.LargeImageList = this.imageList1;
            addItems();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.View = View.SmallIcon;
            this.listView1.SmallImageList = this.imageList1;
            addItems();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.View = View.List;
            this.listView1.SmallImageList = this.imageList1;
            addItems();
        }

        private void addItems()
        {
            this.listView1.BeginUpdate();
            for (int i = 0; i < 9; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "Item" + i;
                this.listView1.Items.Add(lvi);
            }
            this.listView1.EndUpdate();
        }
    }
}