using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HighestLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tester = { 700, 4, 55, 325, 2, 1 };
            int[] view = fun.highestLowest(tester);
            foreach(int num in view)
            {
                WriteLine(num);
            }
           
            ReadLine();
        }
    }
    class fun
    {
        public static int[] highestLowest(int[] lst)
        {
            int[] res = new int[2];
            res[0] = lst.Min();
            res[1] = lst.Max();
            return res; 
        }
    }
}

//using System;

//public class MinMax
//{
//    public static int[] minMax(int[] lst)
//    {
//        int min = lst[0];
//        int max = lst[0];
//        foreach (int num in lst)
//        {
//            if (num > max)
//            {
//                max = num;
//            }
//            if (num < min)
//            {
//                min = num;
//            }
//        }
//        return new int[] { min, max };
//    }
//}
