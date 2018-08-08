using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "This should apear with no duplicate characters.";
            char[] testArray = testString.ToCharArray();
            foreach(char i in testArray)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadLine();
        }
    }
}

//Given a string, remove any repeated letters. 