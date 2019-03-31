using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeircdCase
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine( WeirdCase.toWeirdCase("hello"));

            string big = "this is a string";
            for(int i = 0; i < big.Length; i++)
            {
                big[i].ToString().ToUpper();
                Console.WriteLine(big[i]);
            }

            Console.ReadLine(); 

        }
    }
    class WeirdCase
    {
        public static string toWeirdCase(string s)
        {
            string [] words = s.Split();
            foreach(string tibbie in words)
            {
                //foreach(char tibble in tibbie)
                //{

                    for (int i = 0; i < tibbie.Length; i++)
                    {

                        if (i == 1)
                        {
                            tibbie[i].ToString().ToUpper();
                            //char upper = char.ToUpper(tibbie[i]);
                            //tibble[i] = upper;
                            //tibbie[i] = tibbie.ToUpper(tibbie[i]);
                            //tibbie[i] == Char.ToUpper(tibbie[i]);
                        }
                        
                    }
                //}
                
                
                //tibbie.Split();


            }
            //foreach(char tibbie in s)
            //{

            //}
            //for(int i = 0; i < s.Length; i++)
            //{
            //    //if(s[i])
            //    //{
            //    //   Char.ToUpper(s[i]); 
            //    //}
            //    //else
            //    //{

            //    //}
            //}
            s = string.Join("", words);
            return s;
        }
    }
}
