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

        //constructor
        public Day()
        {
            weather = new Weather();
            dayNames = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        }

        //member method

        public string CurrentDay(string dayName)
        {
            string weekDay = "";
                weekDay += dayNames[0];
                // weekDay = weekDay + dayNames[0];
            return weekDay;
        }
    }
}