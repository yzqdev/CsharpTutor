using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    public abstract class Employee
    {
        private string strCode = "";
        private string strName = "";

        public string Code
        {
            get { return strCode; }
            set { strCode = value; }
        }

        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public abstract void ShowInfoOfEmployee();
    }

    public class MREmployee : Employee
    {
        public override void ShowInfoOfEmployee()
        {
            Console.WriteLine("明日员工的信息:\n" + Code + " " + Name);
        }
    }
}