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

        //static Hashtable alphebetHash;

        static void Main(string[] args)
        {
            //string tester = "This is a test";
            //string[] sArray = tester.Split(' '); 
            //foreach(string word in sArray)
            //{
            //    Console.WriteLine(word);
            //}

            //Instantiate hashtable for alphebet values. 
            Hashtable alphebetHash = new Hashtable();
            //Adding information to the Hashtable 
            //for (int i = 1; i <= 26; i++)
            //{
            alphebetHash.Add('a', 1);
            alphebetHash.Add('b', 2);
            alphebetHash.Add('c', 3);
            alphebetHash.Add('a', 4);
            alphebetHash.Add('a', 5);
            alphebetHash.Add('a', 6);
            alphebetHash.Add('a', 7);
            alphebetHash.Add('a', 8);
            alphebetHash.Add('a', 9);
            alphebetHash.Add('a', 10);
            alphebetHash.Add('a', 11);
            alphebetHash.Add('a', 12);
            alphebetHash.Add('a', 13);
            alphebetHash.Add('a', 14);
            alphebetHash.Add('a', 15);
            alphebetHash.Add('a', 16);
            alphebetHash.Add('a', 17);
            alphebetHash.Add('a', 18);
            alphebetHash.Add('a', 19);
            alphebetHash.Add('a', 20);
            alphebetHash.Add('a', 21);
            alphebetHash.Add('a', 22);
            alphebetHash.Add('a', 23);
            alphebetHash.Add('a', 24);
            alphebetHash.Add('a', 25);
            alphebetHash.Add('a', 26);
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
