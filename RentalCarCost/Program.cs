﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarCost
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalCar rental = new RentalCar();
            Console.WriteLine("HOW MANY DAYS WILL YOU BE RENTING THE CAR?");
            int days = Convert.ToInt32(Console.ReadLine());
            int display = RentalCar.RentalCarCost(days);
            Console.WriteLine(display);

            Console.ReadLine();

        }
    }

    public class RentalCar
    {

        public static int RentalCarCost(int d)
        {
            int cost = 0;

            if (d >= 7)
            {
                cost = d * 40 - 50;
            }
            else if (d >= 3)
            {
                cost = d * 40 - 20;
            }
            else
            {
                cost = d * 40;
            }
            return cost;

          //  return d >= 7 ? d * 40 - 50 : d >= 3 ? d * 40 - 20 : d* 40;

        }
    }

}

// return d >= 7 ? d * 40 - 50 : d >= 3 ? d * 40 - 20 : d* 40;
//return d*40-(d>6?50:d>2?20:0);
//CHALLENGE
//After a hard quarter in the office you decide to get some rest on a vacation.So you will book a flight for you and your girlfriend and try to leave all the mess behind you.

//You will need a rental car in order for you to get around in your vacation.The manager of the car rental makes you some good offers.

//Every day you rent the car costs $40. If you rent the car for 7 or more days, you get $50 off your total.Alternatively, if you rent the car for 3 or more days, you get $20 off your total.

//Write a code that gives out the total amount for different days(d).
