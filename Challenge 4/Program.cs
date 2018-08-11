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
            dupRemove dupRemove = new dupRemove();
            Console.WriteLine("Type something and press enter to have any duplicate characters romoved from it:");
            string userString = Console.ReadLine();
            //string testString = "aaaAAAbbbBBBcccCCCdddDDD";
            char[] testArray = userString.ToCharArray();
            char[] returnedToView = dupRemove.duplicater(testArray);
            //foreach(char i in testArray)
            //{
            //    Console.WriteLine(i);

            //}
            Console.WriteLine(returnedToView);
            Console.ReadLine();
        }
    }
}

//Given a string, remove any repeated letters. 