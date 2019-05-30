using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class UserInterface
    {
        //member variable
        public static int lemonsBought;
        public static int cupsBought;
        public static int sugarBought;
        public static int iceBought;

        //constructor

        //member method
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!" + "\n" + "Your objective is to sell as many cups of lemonade as possible in 7 days." + "\n" + "RULES:" + "\n" + "1. You have a starting budget ($20.00) to operate a lemonade stand." + "\n" + "2. You will choose your recipe for your lemonade that include (lemons, sugar, and ice) and adjust pricing in order to sell the most lemonade." + "\n" + "3. At the beginning of each day, you will be given the week’s forecast and day forecast: bad or fair or good." + "\n" + "4. Based on the weather, you will determine the prices per cup and how many cups of lemonade to make for that day." + "\n" + "5. Demand will depend on the price you set as well as the weather for that day." + "\n" + "6. At the end of each day, you’ll see your daily profit or loss. Play again, and try to beat your high score!");
            Console.ReadLine();
        }
        //This week forecast
        public void ThisWeekForecast(Weather weather, List<string> dayNames)
        {
            string forecast = weather.WeekForecast(dayNames);
            Console.WriteLine("This week 7 days forecast:" + forecast);
            Console.ReadLine();
            Console.WriteLine("**Remember that this is only a forecast. The weather CAN change**");
            Console.ReadLine();
        }

        //Today weather
        public void TodayWeather(Weather weather)
        {
            Console.WriteLine("Today's weather: " + weather.currentWeather);
            Console.ReadLine();
        }

        //Number of Days Played
        public void DaysPlayed(Day day, string dayName)
        {
            string dayOne = day.CurrentDay(dayName);
            Console.WriteLine("Current Day Played:" + dayOne);
            Console.ReadLine();
        }

        //How many cups to buy
        public void NumberOfCups()
        {
            Console.WriteLine("How many cups would you like to buy?" + "\n" + "1 cup = $0.05" + "\n" + "25 cups = $0.83" + "\n" + "50 cups = $1.73" + "\n" + "100 cups = $2.77");
            Console.ReadLine();
        }
        //How many lemons to buy
        public void NumberOfLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?" + "\n" + "1 lemon = $0.10" + "\n" + "10 lemons = $0.91" + "\n" + "30 lemons = $2.41;" + "\n" + "75 cups = $4.31");
            Console.ReadLine();
        }
        //How many sugar to buy
        public void NumberOfSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?" + "\n" + "1 cup os sugar = $0.10" + "\n" + "8 cups of sugar = $0.71" + "\n" + "20 cups of sugar = $1.56" + "\n" + "48 cups of sugar = $3.45");
            Console.ReadLine();
        }
        //How many icecube to buy
        public void NumberOfIceCube()
        {
            Console.WriteLine("How many ice cube would you like to buy?" + "\n" + "1 ice cube = $0.01" + "\n" + "25 ice cubes = $0.20" + "\n" + "50 ice cubes = $0.40" + "\n" + "100 ice cubes = $0.80");
            Console.ReadLine();
        }
        //Price for a cup of lemonade
        public void PriceFor1CupOfLemonade()
        {
            Console.WriteLine("Enter price of your lemonade in cents:");
            Console.ReadLine();
        }

        //Total earning per day
        public void TotalEarningPerDay()
        {
            Console.WriteLine("Player earnings:");
            Console.ReadLine();
            Console.WriteLine("# of cups sale:");
            Console.ReadLine();
            Console.WriteLine("# of money sale:");
            Console.ReadLine();
        }
        //Total earnings for 7 days
        public void TotalEarningPerWeek()
        {
            Console.WriteLine("Player earnings for 7 days report:" + "\n" + "Total Income:" + "\n" + "Total Expenses" + "\n" + "Net Profit or Loss:");
            Console.ReadLine();
        }
        public bool DetermineIfRestart()
        {
            Console.WriteLine("Would you like to play again? Enter: 1 = Yes or 2 = No");
            string yesNo = Console.ReadLine().ToLower();

            switch (yesNo)
            {
                case "1":
                    return true;
                    break;
                case "2":
                    return false;
                default:
                    Console.WriteLine("Invalid input.");
                    return DetermineIfRestart();
                    break;
            }

        
        }
    }
}

