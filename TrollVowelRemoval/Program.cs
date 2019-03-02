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
            //string yaas = Remover.Disemvowel("Hello");
            //Console.WriteLine(yaas);
            //Console.ReadLine();
            //Overrider overrider = new Overrider();
            //int add = overrider.Adder(1, 2);
            //int mult = overrider.Multo(3, 7);
            //Console.WriteLine(add + "\n" + mult); 
            //Console.ReadLine();
            //AbstarctTest abstarctTest = new Overrider();
            //int third = abstarctTest.Multo(8, 7);
            //Console.WriteLine(third);
            //Console.ReadLine();


        }
    }
    static class Remover
    {
        public static string Disemvowel(string str)
        {
            string vowels = "aeiou";
            List<string> words = new List<string>();
            str = words.Where(x => x.All(c => vowels.Contains(c))).ToString();
            return str;
        } 
    }
}
