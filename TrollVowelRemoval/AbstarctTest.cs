using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrollVowelRemoval
{
    public abstract class AbstarctTest
    {
        abstract public int Adder(int a, int b);     
        public virtual int Multo(int c, int d)
        {
            return (c * d); 
        } 
    }
}
