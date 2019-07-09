using System;

namespace csconsoletest
{
    public class Score
    {
        public int Max(int[] array)
        {
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public void setv()
        {
            int[] score = { 34, 67, 89, 34, 100 };
            for (int i = score.GetLowerBound(0); i <= score.GetUpperBound(0); i++)
            {
                score.SetValue(0, i);
                Console.WriteLine("score[{0}]={1}", i, score[i]);
            }
        }

        public void arraysort()
        {
            int[] score = { 34, 67, 89, 34, 100 };
            Console.WriteLine("排序前----------");
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write(score[i] + " ");
            }

            Console.WriteLine("点击enter继续"); Console.ReadLine();
            Array.Sort(score);
            Console.WriteLine("按照升序排列---------");
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write(score[i] + " ");
            }

            Console.WriteLine("点击enter继续"); Console.ReadLine();
            Array.Reverse(score);
            Console.WriteLine("按照降序排列--------");
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write(score[i] + " ");
            }
            Console.ReadLine();
        }

        public void arraycopy()
        {
            Array array = Array.CreateInstance(typeof(Int32), 5);
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(i * i + 10, i);
            }
            Console.WriteLine("Array的数值有");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array.GetValue(i) + "\t");
            }
            Array dest1 = Array.CreateInstance(typeof(Int32), array.Length);
            Array.Copy(array, dest1, 3);

            Console.WriteLine("\n复制后dest1数组的值有:");
            for (int j = 0; j < dest1.Length; j++)
            {
                Console.Write(dest1.GetValue(j) + "\t");
            }
            Array dest2 = Array.CreateInstance(typeof(Int32), array.Length + 2);
            array.CopyTo(dest2, 1);
            Console.WriteLine("\n复制后dest2数组的值有:");
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(dest2.GetValue(k) + "\t");
            }
            Console.ReadLine();
        }
    }
}