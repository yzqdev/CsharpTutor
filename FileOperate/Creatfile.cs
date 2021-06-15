using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.文件操作
{
    internal class Creatfile
    {
        public void creatimg()
        {
            File.Create(@"d:\my.bmp");
        }

        public void creattxt()
        {
            FileStream fs = File.Create("C:\\test1.txt");
        }
    }
}