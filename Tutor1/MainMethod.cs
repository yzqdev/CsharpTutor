using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor1
{
    internal class MainMethod
    {
        public void execMethod()
        {
            Method m = new Method();
            m.caculatetri();
        }

        public void execStringTutor()
        {
            StringTutor stringTutor = new StringTutor();
            stringTutor.stringFunc();
        }
    }
}