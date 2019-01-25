using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            duplicate Duplicate = new duplicate();
            string tester = Duplicate.makeDouble("abcde");
            Console.WriteLine(tester);
            Console.ReadLine();

        }
    }
}
