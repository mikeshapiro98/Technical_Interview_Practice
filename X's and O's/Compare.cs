using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_s_and_O_s
{
    class Compare
    {

        public bool XO(string s)
        {
            return string.Join("", s.Select(x => "" + x + x));
        }

    }
}
