using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Classes
{

    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class CalFather
    {

        /// <summary>
        /// 计算打折后应付多少钱
        /// </summary>
        /// <param name="realMoney">打折前应付的价钱</param>
        /// <returns>打折后应付的前</returns>
        public abstract double GetTotalMoney(double realMoney);
    }
}
