using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    public class Sealedclass
    {
        public virtual void ShowInfoOfPeople()
        {
        }
    }

    public sealed class Student1 : Sealedclass
    {
        private string strCode = "";
        private string strName = "";
        public string Code { get { return strCode; } set { strCode = value; } }

        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public sealed override void ShowInfoOfPeople()
        {
            Console.WriteLine("这个学生的信息：\n" + Code + " " + Name);
        }
    }
}