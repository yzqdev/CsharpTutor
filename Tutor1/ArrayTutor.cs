using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor1
{
    internal class ArrayTutor
    { /// <summary> 初始化数组方法 </summary> <param name= arraytest ></param>
        private static void Init(int[][,] arraytest)
        {
            Console.WriteLine(" 交错数组赋值");
            arraytest[0] = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            arraytest[1] = new int[,] { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };

            arraytest[2] = new int[,] { { 111, 222, 333 }, { 444, 555, 666 }, { 777, 888, 999 } };
        }

        /// <summary> 遍历数组方法 </summary> <param name= arraytest ></param>
        private static void List(int[][,] arraytest)
        {
            Console.WriteLine("输出结果如下");
            Console.WriteLine("******************************");
            for (int i = 0; i < arraytest.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(arraytest[i][j, k] + ", ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void arraymain()
        {
            int[][,] arraytest = new int[3][,];
            //声明数组
            Init(arraytest);
            //初始化数组
            List(arraytest);
            //遍历数组
        }
    }
}