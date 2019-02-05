using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_in_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            int[] peopleInLine2 = new int[] { 25, 25, 50, 50, 100 };
            string answer = linePeeps.Tickets(peopleInLine);
            Console.WriteLine(answer);
            Console.ReadLine();
            string answer2 = linePeeps.Tickets(peopleInLine2);
            Console.WriteLine(answer2);
            Console.ReadLine(); 
        }
    }

    class linePeeps
    {
        public static string Tickets(int[] peopleInLine)
        {


            int twentyFives = 0, fifties = 0;

            foreach (var bill in peopleInLine)
            {
                switch (bill)
                {
                    case 25:
                        ++twentyFives;
                        break;
                    case 50:
                        --twentyFives;
                        ++fifties;
                        break;
                    case 100:
                        if (fifties == 0)
                        {
                            twentyFives -= 3;
                        }
                        else
                        {
                            --twentyFives;
                            --fifties;
                        }
                        break;
                }

                if (twentyFives < 0 || fifties < 0)
                {
                    return "NO";
                }
            }

            return "YES";





            //string yesOrNo;
            //if(peopleInLine[0] != 25)
            //{
            //    yesOrNo = "NO"; 
            //}
            //else if (peopleInLine[1] < 100 && peopleInLine[2] <= 50 && peopleInLine[3] <= 50 && peopleInLine.Length < 5)
            //{
            //    yesOrNo = "YES";
            //}
            //else if(peopleInLine.Length > 4)
            //{
            //    if (peopleInLine[1] < 100 && peopleInLine[2] <= 50 && peopleInLine[3] <= 50 && peopleInLine[4] <= 50)
            //    {
            //        yesOrNo = "YES";
            //    }
            //    else
            //    {
            //        yesOrNo = "NO"; 
            //    }

            //}        
            //else
            //{
            //    yesOrNo = "NO"; 
            //}
            //return yesOrNo; 
        }
    }
}

//CHALLENGE:
//The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line.Each of them has a single 100, 50 or 25 dollars bill.An "Avengers" ticket costs 25 dollars.

//Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.

//Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the order people follow in the line?


//Return YES, if Vasya can sell a ticket to each person and give the change with the bills he has at hand at that moment. Otherwise return NO.