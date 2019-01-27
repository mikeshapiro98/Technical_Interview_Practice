using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(binary.C2B(1, 2));
            Console.ReadLine(); 
        }
    }

    static class binary
    {
        public static string C2B (int a, int b)
        {
          //  string result = ConvertToBinary(a + b);
            return Convert.ToString(a+b, 2); 
        }


    }

}

//CHALLENGE: 
//Implement a function that adds two numbers together and returns their sum in binary.The conversion can be done before, or after the addition.

//The binary number returned should be a string.
