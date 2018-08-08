using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class oddAdder
    {
        public int adderAid(int[] i)
        {
            List<int> tempers = new List<int>();
            for(int j=0; j<i.Length;j++)
            {
                if (i[j] %2 != 0)
                {
                    tempers.Add(i[j]);
                }
            }
            int tots = tempers.Sum();
            return tots;

        }

    }
}
