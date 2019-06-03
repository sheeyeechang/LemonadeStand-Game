using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variable
        public Weather weather;
        public List<string> dayNames;
        public string dayName;
        public Customer customer;    

        //constructor
        public Day()
        {
            weather = new Weather();
            dayNames = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            customer = new Customer();
        }

        //member method

        public string CurrentDay(int dayName)
        {
            return dayNames[dayName];
            // weekDay = weekDay + dayNames[0];
        }
        public void ResetLemonadeSoldPerDay(Player player)
        {
            player.soldLemonade = 0;
        }

    }
}