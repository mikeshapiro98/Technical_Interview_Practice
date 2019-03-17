using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 


namespace stringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "This is a string that should have each word reversed on the next line.";
            WriteLine(user);
            WriteLine(Reverse.inReverse(user));
            ReadLine(); 
        }
    }
    class Reverse
    {
        public static string inReverse(string str)
        {

            string[] Parced = str.Split(' ');
            string final = " ";
            foreach (string word in Parced)
            {
                string result = "";

                foreach (char letter in word.ToCharArray())
                {
                    result = letter + result;
                }
                final = final + result + " ";
            }
            return final;


            //string strrev = "";

            //foreach (var word in str.Split(' '))
            //{
            //    string temp = "";
            //    foreach (var ch in word.ToCharArray())
            //    {
            //        temp = ch + temp;
            //    }
            //    strrev = strrev + temp + " ";
            //}
            //return strrev;

        }
    }
}








// return string.Join(" ",str.Split(' ').Select(x => new String(x.Reverse().ToArray())).ToArray());


//PROMPT
//Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
//Examples

//"This is an example!" ==> "sihT si na !elpmaxe"
//"double  spaces"      ==> "elbuod  secaps"


//Alternative Solution
//string str = "I am going to reverse myself.";
//string strrev = "";

//  foreach (var word in str.Split(' '))
//  {
//     string temp = "";
//     foreach (var ch in word.ToCharArray())
//     {
//         temp = ch + temp;
//     }
//     strrev = strrev + temp + "";
//  }
//  Console.WriteLine(strrev);  //I ma gniog ot esrever .flesym