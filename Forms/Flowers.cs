using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2
{
    public class Flowers
    {
        //四个代表鲜花类属性的数据成员,用于记录鲜花对象的名称,产地,价格,数量
        string name, location;
        int num;
        double price;
        //类的静态数据成员用于记录鲜花的种类数量
        static int type_num = 0;
        //类的私有数据成员对应的get,set访问器;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public static int Type_num
        {
            get
            {
                return Flowers.type_num;
            }
        }
        public int Num
        {
            get { return num; }
            set
            {
                num = value;
            }
        }
        /// <summary>
        /// 类的无参构造函数,当增加一种鲜花时,需对鲜花的种类数量增加
        /// </summary>
        public Flowers()
        {
            type_num++;
        }
        /// <summary>
        /// 类的三参构造函数,使用名称,产地,价格初始化类的对象,并增加爱鲜花的种类数量
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="price"></param>
        public Flowers(string name, string location, double price)
        {
            this.name = name;
            this.location = location;
            this.price = price;
            type_num++;
        }
        //类的析构函数
        ~Flowers()
        {
            type_num--;
        }
        //类的私有方法成员,用于计算鲜花数量的增加或者减少
        public void record(int num)
        {
            this.num += num;
        }
        //进货方法
        public void add(int num) { record(num); }
        //销货方法
        public bool reduce(int num)
        {
            if (this.num < num) { return false; } else { record(-num); return true; }
        }//返回鲜花对象的实时属性信息
        public string showinfo()
        {
            return string.Format("{0}共有{1}支,售价为{2},产地为{3}", name, num, price, location);
        }
    }
}