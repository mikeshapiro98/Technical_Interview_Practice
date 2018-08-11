using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class dupRemove
    {
        public char[] duplicater(char[] c)
        {
            List<char> temp = c.ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp.Count; j++)
                {
                    if(temp[j]==temp[i])
                    {
                        temp.Remove(temp[j]);
                    }
                }
            }
            c = temp.ToArray();

            return c; 

        }

    }
}
