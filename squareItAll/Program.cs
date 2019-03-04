using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareItAll
{
    class Program
    {
        static void Main(string[] args)
        {

            int disp = Splitter.SquareGigits(234);
            Console.WriteLine(disp); 
            Console.ReadLine();

        }
    }
    class Splitter
    {
        public static int SquareGigits(int n)
        {
            string str = n.ToString();
            //var charArray = n.ToString().ToCharArray();
            int[] splitter = str.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
            string spc = "";
            foreach (int num in splitter)
            {
                int hold = num * num;
                spc = spc + hold.ToString();
            }
            n = Convert.ToInt32(spc); 
            return n;

        }
    }
}
//PROMPT:
//You are asked to square every digit of a number.

//For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

//Note: The function accepts an integer and returns an integer
