using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrollVowelRemoval
{
    class Overrider : AbstarctTest
    {
        public override int Adder(int a, int b)
        {
            return (a + b); 
        }
        public override int Multo(int c, int d)
        {
           // return base.Multo(c, d);
            return (c - d);
        }

    }
}
