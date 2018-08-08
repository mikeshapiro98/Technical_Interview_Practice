using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Adders adders = new Adders();            
            int[] testArray = new int[] {1, 1773, 2847, 8371, 77875, 973636, 62542738  };
            decimal tots = adders.bigNum(testArray);
            Console.WriteLine(tots);
            Console.ReadLine();
        }
    }
}

//Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers. 