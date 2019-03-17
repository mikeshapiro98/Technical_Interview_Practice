using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace sumOfTwoLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res = { 7, 3, 3, 1, 6, 2 };
            WriteLine(sumTwo.sumTwoSmallestNumbers(res));
            foreach (int num in res)
            {
                WriteLine(num);
            }
            ReadLine();
          

        }
    }
    class sumTwo
    {

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[0] + numbers[1];
            //return numbers.OrderBy(i => i).Take(2).Sum();
        }

    }
}


//PROMPT
//Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 integers.No floats or empty arrays will be passed.

//For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.


//[10, 343445353, 3453445, 3453545353453] should return 3453455.






//int smallest = numbers.Min();
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > smallest && )
//}

