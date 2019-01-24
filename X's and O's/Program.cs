using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_s_and_O_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Compare compare = new Compare();
            string tester = "xoxo";
            string tester2 = "xxooo";
            string tester3 = "abc";
            bool a1 = compare.XO(tester);
            bool a2 = compare.XO(tester2);
            bool a3 = compare.XO(tester3);
            Console.WriteLine(a1 +" "+ a2 +" " +a3);
            Console.ReadLine();
        }
    }
}

//CHALLENGE:

//Check to see if a string has the same amount of 'x's and 'o's.The method must return a boolean and be case insensitive.The string can contain any char.

//Examples input/output:
//XO("ooxx") => true
//XO("xooxx") => false
//XO("ooxXm") => true
//XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
//XO("zzoo") => false
