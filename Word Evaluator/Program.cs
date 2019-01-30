using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Evaluator
{
    class Program
    {

        static Hashtable alphebetHash;

        static void Main(string[] args)
        {
            //string tester = "This is a test";
            //string[] sArray = tester.Split(' '); 
            //foreach(string word in sArray)
            //{
            //    Console.WriteLine(word);
            //}
            




            //for (char a = 'A'; a <= 'Z'; a++)
            //{
            //    int isolation = ;
            //    Console.WriteLine(a);
            //}

            Console.ReadLine();


        }
    }
    class wordValue
    {
        public string vauluator(string s)
        {

            string[] seperator = s.Split(' ');
           // List<char> evaluators= new List<char>();
            
            foreach(string word in seperator)
            {
                foreach(char c in word)
                {
                    for (char a = 'A'; a <= 'Z'; a++)
                    {

                    }
                }


            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                 
            }


            return "hold";
        }
    }
}


//CHALLENGE
//Given a string of words, you need to find the highest scoring word.

//Each letter of a word scores points according to it's position in the alphabet: a = 1, b = 2, c = 3 etc.

//You need to return the highest scoring word as a string.

//If two words score the same, return the word that appears earliest in the original string.

//All letters will be lowercase and all inputs will be valid.
