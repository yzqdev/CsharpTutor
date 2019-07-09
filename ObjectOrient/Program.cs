using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csconsoletest2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainform());
            //窗口程序显示
            Methodtest methodtest = new Methodtest();

            //methodtest.calcarea();
            //methodtest.coll();
            //methodtest.sfruit();
        }
    }
}