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
            string big = "this is a string";
            Console.WriteLine(WeirdCase.toWeirdCase(big));
            Console.ReadLine(); 
        }
    }
    class WeirdCase
    {
        public static string toWeirdCase(string s)
        {
            List<string> holder = new List<string>();
            string [] words = s.Split();
            foreach (string tibbie in words)
            {
                char[] a = tibbie.ToCharArray();
                for (int i = 0; i < a.Length; i++)
                {

                    if (i == 0 || i % 2 == 0)
                    {                                                  
                         a[i] = char.ToUpper(a[i]);                       
                    }
                        
                }
                string z = new string(a);
                holder.Add(z);
            }
            s = string.Join(" ", holder.ToArray());
             return s;         
        }
    }
}


//Graveyard

//  string z = new string(a);    

//var d 
//a[i] = d; 
// holder.Join().ToString();
//s = string.Join("", words);
// return holder;



// Console.WriteLine( WeirdCase.toWeirdCase("hello"));

//for(int i = 0; i < big.Length; i++)
//{
//    big[i].ToString().ToUpper();
//    Console.WriteLine(big[i]);
//}


//foreach (char tibble in tibbie)
//{

// }



//Char.ToUpper(tibbie[i]);                           
//tibbie[i].ToString().ToUpper();
//char upper = char.ToUpper(tibbie[i]);
//tibble[i] = upper;
//tibbie[i] = tibbie.ToUpper(tibbie[i]);
//tibbie[i] == Char.ToUpper(tibbie[i]);


//tibbie.Split();


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