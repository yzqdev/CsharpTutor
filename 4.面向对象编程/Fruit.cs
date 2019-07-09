using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{/// <summary>
/// 类的继承 </summary>
    internal class Fruit
    {
        private string name;

        private string color; public Fruit(string str)
        {
            name = str;
        }

        public string Color
        {
            set { color = value; }
        }

        public void Information()
        {
            Console.WriteLine("{0}  颜色：{1}", name, color);
        }
    }

    /// <summary>
    /// apple继承fruit类
    /// </summary>
    internal class Apple : Fruit
    {
        private string name; private string color;

        /// <summary>
        /// 带参数的构造函数必须显式调用就是class（）：base
        /// </summary>
        /// <param name="str"></param>
        public Apple(string str) : base(str)
        {
            name = str;
        }
    }
}