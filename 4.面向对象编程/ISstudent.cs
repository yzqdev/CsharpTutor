using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{ /// <summary>
/// 接口的声明 </summary>
    internal interface ISstudent
    {
        string StudentCode { get; set; }//声明编号
        string StudentName { get; set; }//声明姓名

        void ShowInfoOfStudent();//声明方法
    }

    /// <summary>
    /// 实现接口
    /// </summary>
    internal class Pstudent : ISstudent
    {
        private string strId = "";
        private string strName = "";
        public string StudentCode { get { return strId; } set { strId = value; } }

        public string StudentName { get { return strName; } set { strName = value; } }

        public void ShowInfoOfStudent()
        {
            Console.WriteLine("编号\t姓名");
            Console.WriteLine(StudentCode + "\t" + StudentName);
        }
    }
}