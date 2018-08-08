using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Adders
    {
        public decimal bigNum (int[] i)
        {
            int intAdd = i.Sum();
            decimal longAdd = Convert.ToDecimal(intAdd);
            return longAdd;
        }
    }
}
