using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class reverser
    {
        public string rever (string s)
        {
            char[] reverse = s.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse); 
        }
    }
}
