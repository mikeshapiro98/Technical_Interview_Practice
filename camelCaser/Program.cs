﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camelCaser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Camel.camelCase(" this is a test"));
            Console.ReadLine();
        }
    }
    class Camel
    {
        public static string camelCase(string s)
        {
            char[] charArray = s.ToCharArray();
            string d2 = "";
            bool isIt = true;
            //foreach(char c in charArray)
            //{
            //    Console.WriteLine(c); 
            //}
            //s[0] = char.ToUpper(s[0]);
            for (int i = 0; i < charArray.Length; i++)
            {
                 if (charArray[i] == ' ')
                {
                    isIt = true;
                    // d2 += char.ToUpper(charArray[i + 1]);
                    // charArray[i] = 
                }
                else  if (isIt)
                {
                   
                    d2 += char.ToUpper(charArray[i]);
                    isIt = false; 
                }
            
                else
                {
                    d2 += charArray[i];
                }
            }
          //  string d2 = new string(charArray);
            return d2;
           // s = string.Join(d2)
        }
    }
}


