using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    internal interface Icalculate1
    {
        int Add();
    }

    internal interface Icalculate2
    {
        int Add();
    }

    internal class Compute : Icalculate1, Icalculate2
    {
        int Icalculate1.Add()
        {
            int x = 10;
            int y = 40;
            return x + y;
        }

        int Icalculate2.Add()
        {
            int x = 10; int y = 40; int z = 50;
            return x + y + z;
        }
    }
}