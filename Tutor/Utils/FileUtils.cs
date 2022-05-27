using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Utils
{
    internal class FileUtils
    {
        public static void CopyFile(string soucre, string target)
        {
            //1、我们创建一个负责读取的流
            using (FileStream fsRead = new FileStream(soucre, FileMode.Open, FileAccess.Read))
            {
                //2、创建一个负责写入的流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //因为文件可能会比较大，所以我们在读取的时候 应该通过一个循环去读取
                    while (true)
                    {
                        //返回本次读取实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //如果返回一个0，也就意味什么都没有读取到，读取完了
                        if (r == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }


                }
            }
        }
    }
}
