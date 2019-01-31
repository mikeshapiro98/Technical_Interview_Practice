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
            //Hashtable alphebetHash = new Hashtable();
            //Adding information to the Hashtable 
            //for (int i = 1; i <= 26; i++)
            //{
            //alphebetHash.Add('a', 1);
            //alphebetHash.Add('b', 2);
            //alphebetHash.Add('c', 3);
            //alphebetHash.Add('d', 4);
            //alphebetHash.Add('e', 5);
            //alphebetHash.Add('f', 6);
            //alphebetHash.Add('g', 7);
            //alphebetHash.Add('h', 8);
            //alphebetHash.Add('i', 9);
            //alphebetHash.Add('j', 10);
            //alphebetHash.Add('k', 11);
            //alphebetHash.Add('l', 12);
            //alphebetHash.Add('m', 13);
            //alphebetHash.Add('n', 14);
            //alphebetHash.Add('o', 15);
            //alphebetHash.Add('p', 16);
            //alphebetHash.Add('q', 17);
            //alphebetHash.Add('r', 18);
            //alphebetHash.Add('s', 19);
            //alphebetHash.Add('t', 20);
            //alphebetHash.Add('u', 21);
            //alphebetHash.Add('v', 22);
            //alphebetHash.Add('w', 23);
            //alphebetHash.Add('x', 24);
            //alphebetHash.Add('y', 25);
            //alphebetHash.Add('z', 26);

            //Console.WriteLine(alphebetHash);

            //foreach(DictionaryEntry key in alphebetHash)
            //{
            //    Console.WriteLine(key.Key);
            //}

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


            s = s.Split(' ');
            var[max, word] = [0, ""];






















            //int counter = 0;
            //string[] splitter = s.Split(' ');

            //foreach (string word in splitter)
            //{
            //    foreach(char c in word)
            //    {
            //        int counter2 = 0;
            //        switch (c)
            //        {
                        
            //            case 'a':
            //                counter2 =+ 1;
            //                break;
            //            case 'b':
            //                counter2 = +2;
            //                break;
            //            case 'c':
            //                counter2 = +3;
            //                break;
            //            case 'd':
            //                counter2 = +4;
            //                break;
            //            case 'e':
            //                counter2 = +5;
            //                break;
            //            case 'f':
            //                counter2 = +6;
            //                break;
            //            case 'g':
            //                counter2 = +7;
            //                break;
            //            case 'h':
            //                counter2 = +8;
            //                break;
            //            case 'i':
            //                counter2 = +9;
            //                break;
            //            case 'j':
            //                counter2 = +10;
            //                break;
            //            case 'k':
            //                counter2 = +11;
            //                break;
            //            case 'l':
            //                counter2 = +12;
            //                break;
            //            case 'm':
            //                counter2 = +13;
            //                break;
            //            case 'n':
            //                counter2 = +14;
            //                break;
            //            case 'o':
            //                counter2 = +15;
            //                break;
            //            case 'p':
            //                counter2 = +16;
            //                break;
            //            case 'q':
            //                counter2 = +17;
            //                break;
            //            case 'r':
            //                counter2 = +18;
            //                break;
            //            case 's':
            //                counter2 = +19;
            //                break;
            //            case 't':
            //                counter2 = +20;
            //                break;
            //            case 'u':
            //                counter2 = +21;
            //                break;
            //            case 'v':
            //                counter2 = +22;
            //                break;
            //            case 'w':
            //                counter2 = +23;
            //                break;
            //            case 'x':
            //                counter2 = +24;
            //                break;
            //            case 'y':
            //                counter2 = +25;
            //                break;
            //            case 'z':
            //                counter2 = +26;
            //                break;
            //        }

            //        counter = counter2 + counter2; 


                //}
            }







           // string[] seperator = s.Split(' ');
           //// List<char> evaluators= new List<char>();
            
           // foreach(string word in seperator)
           // {
           //     foreach(char c in word)
           //     {
           //         for (char a = 'A'; a <= 'Z'; a++)
           //         {

           //         }
           //     }


           // }

           // for (char c = 'A'; c <= 'Z'; c++)
           // {
                 
           // }


           // return "hold";
        }
    }
}


//CHALLENGE
//Given a string of words, you need to find the highest scoring word.

//Each letter of a word scores points according to it's position in the alphabet: a = 1, b = 2, c = 3 etc.

//You need to return the highest scoring word as a string.

//If two words score the same, return the word that appears earliest in the original string.

//All letters will be lowercase and all inputs will be valid.
