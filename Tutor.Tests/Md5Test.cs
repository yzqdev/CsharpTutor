using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests
{
    internal class Md5Test
    {
        [Test]
        public void Md5Text()
        {
            string s = GetMD5("123");
            Console.WriteLine(s);
        }
        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //需要将字符处转换成字节数组
            byte[] buffer = Encoding.GetEncoding("UTF-8").GetBytes(str);
            //返回一个加密好的字节数组
            byte[] MD5Buffer = md5.ComputeHash(buffer);

            //将字节数组转换成字符串
            //字节数组---字符串
            //将字节数组中每个元素按照指定的编码格式解析成字符串
            //直接将数组ToString();
            //将字节数组中的每个元素ToString()
            //  return Encoding.GetEncoding("GBK").GetString(MD5Buffer);

            // 189 273 345 我爱你
            // 189 273 345
            string strNew = "";
            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                strNew += MD5Buffer[i].ToString("x2");
            }
            return strNew;
        }
    }
}
