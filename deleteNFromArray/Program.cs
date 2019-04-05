using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleteNFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tester = new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 5, 6, 6, 6, 7, 7, 7 };
            int [] tester2 = RemoveN.DeleteNth(tester, 2);
            foreach(int n in tester2)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
    class RemoveN
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            int[] results; //=  new int[] { arr.Where(g => g.Count() < x)};
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
            }
            return results;
        }
    }


}
//Task

//Given a list lst and a number N, create a new list that contains each number of lst at most N times without reordering.For example if N = 2, and the input is [1,2,3,1,2,1,2,3], you take[1, 2, 3, 1, 2], drop the next[1, 2] since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to[1, 2, 3, 1, 2, 3].