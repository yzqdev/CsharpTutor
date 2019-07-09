using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    internal class Coll
    {
        public const int intMaxNum = 3;//表示数组的长度
        private string[] arrStr;//声明数组的引用

        public string this[int index]//定义索引器
        {
            get { return arrStr[index]; }//通过索引器取值
            set { arrStr[index] = value; }//通过索引器赋值
        }

        public Coll()
        {
            arrStr = new string[intMaxNum];//设置数组的长度
        }
    }
}