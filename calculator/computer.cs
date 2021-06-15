using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace WindowsFormsApplication1
{
    public class computer
    {
        public double ANS = 0, number1 = 0, number2 = 0, ans = 0, FAns = 0;
        public string buff;
        public int sign = 1;
        public void zuhe()
        {
            for (; number2 >= 1;)
            {
                number2 = number2 / 10;
            }
            ans = (number1 + number2) * sign;
            sign = 1;
            number1 = 0;
            number2 = 0;
        }
        public void doMath()
        {
            switch (buff)
            {
                case "+":
                    {
                        ANS += ans;
                        ans = ANS;
                        break;
                    }
                case "-":
                    {
                        ANS -= ans;
                        ans = ANS;
                        break;
                    }
                case "*":
                    {
                        ANS = ANS * ans;
                        ans = ANS;
                        break;
                    }
                case "%":
                    {
                        ANS = ANS % ans;
                        ans = ANS;
                        break;
                    }
                case "\\":
                    {
                        ANS = (int)(ANS / ans);
                        ans = ANS;
                        break;
                    }
                case "^":
                    {
                        ANS = Math.Pow(ANS, ans);
                        ans = ANS;
                        break;
                    }
                case "log":
                    {
                        ANS = FAns / Math.Log(ans);
                        ans = ANS;
                        break;
                    }
                case "/":
                    {
                        if (ans == 0)
                        {
                            MessageBox.Show("脑残啊，0都可以当除数啊！！！");
                        }
                        else
                        {
                            ANS = ANS / ans;
                            ans = ANS;
                        }
                        break;
                    }
                default:
                    {
                        ANS = ans;
                        break;
                    }
            }
            buff = "";

        }
    }

}
