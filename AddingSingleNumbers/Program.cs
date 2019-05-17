using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingSingleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] even = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int [] newArr = odds.NoOdds(even);
            foreach(int n in newArr)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

        }
    }
    static class odds
    {
        public static int[] NoOdds(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }
    }
}

//Create a function that takes an array of numbers and returns only the even values.
//Examples

//NoOdds([1, 2, 3, 4, 5, 6, 7, 8]) ➞ [2, 4, 6, 8]

//NoOdds([43, 65, 23, 89, 53, 9, 6]) ➞ [6]

//NoOdds([718, 991, 449, 644, 380, 440]) ➞ [718, 644, 380, 440]
