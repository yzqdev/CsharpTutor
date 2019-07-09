using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.文件操作
{
    internal class Openfiletest
    {
        public void opentxt()
        {
            FileInfo fileinfo = new FileInfo("D:\\test.txt");
            try
            {
                using (Stream stream = fileinfo.Open(FileMode.Open))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("你是蜘蛛吗？");
                    stream.Write(info, 0, info.Length);
                    MessageBox.Show("文件已保存");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}