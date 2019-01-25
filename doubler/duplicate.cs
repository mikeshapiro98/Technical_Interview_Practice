using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubler
{
    class duplicate
    {
        
        public string makeDouble(string s)
        {
            string newer = " ";
            foreach(char c in s)
            {
                newer =c + c + c;
            }

            return newer;
        }

    }
}
