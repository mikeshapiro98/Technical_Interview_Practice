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

        }
    }
    static class Remover
    {
        public static string Disemvowel(string str)
        {

            return str;
        } 
    }
}
