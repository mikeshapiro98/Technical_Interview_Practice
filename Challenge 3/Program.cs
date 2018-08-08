using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            reverser reverser = new reverser();
            string testString = "Hello World Of Wonder";
            string tots = reverser.rever(testString);
            Console.WriteLine(testString);
            Console.WriteLine(tots);
            Console.ReadLine();
        }
    }
}

//Given a string, reverse it.
