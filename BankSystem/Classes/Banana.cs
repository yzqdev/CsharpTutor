using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Classes
{
    class Banana : ProductFather
    {
        public Banana(string id, double price, string Name)
            : base(id, price, Name)
        {

        }
    }
}
