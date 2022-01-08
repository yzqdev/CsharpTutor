using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Algo
{
    internal class SortTest
    {
        [Test]
        public void BubbleSort()
        {
            int[] numbers = { 11, 2, 55, 64, 3, 9, 17 };
            //升序排列
            Array.Sort(numbers);
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
           
        }
    }
}
