using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrollVowelRemoval
{
    class Override : AbstarctTest
    {
        public virtual int Adder(int a,int b)
        {
            return (a * b); 
        } 
    }
}
