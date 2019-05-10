using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenCowsPigs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(farm.legs(10, 5, 12));
            Console.ReadLine();           
        }
    }
    static class farm
    {
        public static int legs(int chickens, int cows, int pigs)
        {
            return chickens * 2 + cows * 4 + pigs * 4; 
        }
    }
}

//You've got chickens (2 legs), cows (4 legs) and pigs (4 legs) on your farm. Return the total number of legs on your farm.
//Examples

//animals(2, 3, 5) ➞ 36

//animals(1, 2, 3) ➞ 22

//animals(5, 2, 8) ➞ 50
