using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Technical Interview Practice exercise 1. Press enter to start");
            ReadLine();

            oddAdder odders = new oddAdder();
            int[] testArray = new int[] { 1,3,4,8,11,15 };

            int total = odders.adderAid(testArray);
            //List<int> adderList = new List<int>();
            //foreach(int ooe in testArray)
            //{
            //    if(ooe %2 != 0)
            //    {
            //        adderList.Add(ooe);
            //        //Write("The following numbers in the array are odd" + ooe);
            //    }
            //}
            //int total = adderList.Sum();
            WriteLine(total);
            ReadLine();
        
        }
    }
}

//Given an array of integers, write a method to total the odd numbers. 