using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrollVowelRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            string yaas = Remover.Disemvowel("Hello");
            Console.WriteLine(yaas);
            Console.ReadLine();
            //Overrider overrider = new Overrider();
            //int add = overrider.Adder(1, 2);
            //int mult = overrider.Multo(3, 7);
            //Console.WriteLine(add + "\n" + mult); 
            //Console.ReadLine();
            //AbstarctTest abstarctTest = new Overrider();
            //int third = abstarctTest.Multo(8, 7);
            //Console.WriteLine(third);
            //Console.ReadLine();
            //moreMoreMore moreMoreMore = new moreMoreMore();
            //int third = moreMoreMore.Multo(8, 2);
            //int fourth = moreMoreMore.Adder(2,2); 
            //Console.WriteLine(third+"\n"+fourth);
            //Console.ReadLine();


        }
    }
    static class Remover
    {
        public static string Disemvowel(string str)
        {
           // IEnumerable<char> vowels = "aeiouAEIOU";
           // StringBuilder exper = new StringBuilder();
           // for (int i = 0; i < str.Length; i++)
           // {
           //     if (!vowels.Contains(str[i]))
           //     {
           //         exper.Append(str[i]);
           //     }
           // }
           // str = exper.ToString(); 
           //return str;


            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));

        } 
    }
}
