using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            duplicate Duplicate = new duplicate();
            string tester = Duplicate.makeDouble("abcde");
            Console.WriteLine(tester);
            Console.ReadLine();

        }
    }
}

//CHALLENGE:
//Given a string, you have to return a string in which each character(case-sensitive) is repeated once.
//DoubleChar("String") == "SSttrriinngg"
//DoubleChar("Hello World") == "HHeelllloo  WWoorrlldd"
//DoubleChar("1234!_ ") == "11223344!!__  "

