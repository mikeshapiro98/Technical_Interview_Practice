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
            string lower = s.ToLower();
            int xs = 0;
            int os = 0;
            foreach (char xo in lower)
            {
                if(xo == 'x')
                {
                    xs++;
                }
                else if(xo == 'o')
                {
                    os++;
                }
            }
        
        }

    }
}
