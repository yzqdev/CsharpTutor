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
    public partial class MousePosition : Form
    {
        public MousePosition()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelmouseposition.Text = "鼠标当前坐标[X:" + Cursor.Position.X + "  Y:" + Cursor.Position.Y + "]";
            labelwindowposition.Text = "窗口坐标[X:" + this.Location.X + " Y:" + this.Location.Y + "]";
            labelwindowsize.Text = "窗口大小[宽:" + this.Width + " 长:" + this.Height + "]";
        }

        private void MousePosition_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;							//设置拖放操作中目标放置类型为复制
            String[] str_Drop = (String[])e.Data.GetData(DataFormats.FileDrop, true);//检索数据格式相关联的数据
            MessageBox.Show(str_Drop[0]);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}