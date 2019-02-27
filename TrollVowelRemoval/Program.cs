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
            //overrider.Adder(1, 2);
        }
    }
    static class Remover
    {
        public static string Disemvowel(string str)
        {
            string vowels = "aeiou";
            List<string> words = new List<string>();
            str = words.Where(x => x.All(c => vowels.Contains(c))).ToString(); 
            return str
        } 
    }
}
