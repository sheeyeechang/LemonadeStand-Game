using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public static class UserInterface
    {
        //member variable
        public static int lemonsBought;
        public static int cupsBought;
        public static int sugarBought;
        public static int iceBought;

        //constructor

        //member method
        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!" + "\n" + "Your objective is to sell as many cups of lemonade as possible in 7 days." + "\n" + "RULES:" + "\n" + "1. You have a starting budget ($20.00) to operate a lemonade stand." + "\n" + "2. You will choose your recipe for your lemonade that include (lemons, sugar, and ice) and adjust pricing in order to sell the most lemonade." + "\n" + "3. At the beginning of each day, you will be given the week’s forecast and day forecast: bad or fair or good." + "\n" + "4. Based on the weather, you will determine the prices per cup and how many cups of lemonade to make for that day." + "\n" + "5. Demand will depend on the price you set as well as the weather for that day." + "\n" + "6. At the end of each day, you’ll see your daily profit or loss. Play again, and try to beat your high score!");
            Console.ReadLine();
        }
        //This week forecast
        public static void ThisWeekForecast(Weather weather, List<string> dayNames)
        {
            string forecast = weather.WeekForecast(dayNames);
            Console.WriteLine("This week 7 days forecast:" + forecast);
            Console.ReadLine();
            Console.WriteLine("**Remember that this is only a forecast. The weather CAN change**");
            Console.ReadLine();
        }

        //Today weather
        public static void TodayWeather(Weather weather)
        {
            Console.WriteLine("Today's weather: " + weather.currentWeather);
            Console.ReadLine();
        }

        //Number of Days Played
        public static void DaysPlayed(Day day, string dayName)
        {
            string dayOne = day.CurrentDay(dayName);
            Console.WriteLine("Current Day Played:" + dayOne);
            Console.ReadLine();
        }
        //Wallet to start
        public static void WalletToStart(Player player)
        {
            Console.WriteLine($"Wallet: ${player.wallet.money}");
        }

        //How many cups to buy
        public static int NumberOfCups()
        {
            Console.WriteLine("How many cups would you like to buy?" + "\n" + "1 cup = $0.05");
            int enterCup = int.Parse(Console.ReadLine());
            if (enterCup > 0)
            {
                return enterCup;
            }
            else
            { 
                Console.WriteLine("Invalid input.");
                return NumberOfCups();
            }

        }


        //Display stats
        public static void DisplayStats(Player player)
        {
            int countCup = player.inventory.CountCup();
            int countLemon = player.inventory.CountLemon();
            int countSugar = player.inventory.CountSugar();
            int countIceCube = player.inventory.CountIceCube();
            Console.WriteLine($"Cup: {countCup}" + "   " + $"Lemon: {countLemon}" + "   " + $"Sugar: {countSugar}" + "   " + $"Ice cube: {countIceCube}");
        }
        //Display money count Cup
        public static void DisplayMoneyCountCup(Store store, Player player, int numberOfItem)
        {
            decimal countMoneyCup = store.CountCupPrice(numberOfItem);
            Console.WriteLine($"Wallet: ${player.wallet.money -= countMoneyCup}");
        }

        //How many lemons to buy
        public static int NumberOfLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?" + "\n" + "1 lemon = $0.15");
            int enterLemon = int.Parse(Console.ReadLine());
            if (enterLemon > 0)
            {
                return enterLemon;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return NumberOfLemons();
            }
        }
        //Display money count Lemon
        public static void DisplayMoneyCountLemon(Store store, Player player, int numberOfItem)
        {  
            decimal countMoneyLemon = store.CountLemonPrice(numberOfItem);
            Console.WriteLine($"Wallet: ${player.wallet.money -= (countMoneyLemon)}");
        }
        //How many sugar to buy
        public static int NumberOfSugars()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?" + "\n" + "1 cup of sugar = $0.10");
            int enterSugar = int.Parse(Console.ReadLine());
            if (enterSugar > 0)
            {
                return enterSugar;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return NumberOfSugars();
            }
        }
        //Display money count Sugar
        public static void DisplayMoneyCountSugar(Store store, Player player, int numberOfItem)
        {
            decimal countMoneySugar = store.CountSugarPrice(numberOfItem);
            Console.WriteLine($"Wallet: ${player.wallet.money -= countMoneySugar}");
        }
        //How many icecube to buy
        public static int NumberOfIceCubes()
        {
            Console.WriteLine("How many ice cube would you like to buy?" + "\n" + "1 ice cube = $0.02");
            int enterIceCube = int.Parse(Console.ReadLine());
            if (enterIceCube > 0)
            {
                return enterIceCube;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return NumberOfIceCubes();
            }
        }
        //Display money count Ice Cube
        public static void DisplayMoneyCountIceCube(Store store, Player player, int numberOfItem)
        {
            decimal countMoneyIceCube = store.CountIceCubePrice(numberOfItem);
            Console.WriteLine($"Wallet: ${player.wallet.money -= (countMoneyIceCube)}");
        }
        //Display not enough money
        public static bool NotEnoughMoney(Player player)
        {
            if (player.wallet.money <= 0)
            {
                Console.WriteLine("You don't have enough money!");
                return true;
            }
            else
            {
                return false;
            }
        }
        //Make lemonade//Recipe
        //Number of Cup used to make lemonade
        public static int CupUsedToMakeLemonade(Recipe recipe, Inventory inventory)
        {
            Console.WriteLine("How many cup would you use to make lemonade?");
            recipe.numberOfCup = int.Parse(Console.ReadLine());
            if (recipe.numberOfCup <= inventory.CountCup())
            {
                return recipe.numberOfCup;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return LemonUsedToMakeLemonade(recipe, inventory);
            }
        }

        //Number of Lemon used to make lemonade
        public static int LemonUsedToMakeLemonade(Recipe recipe, Inventory inventory)
        {          
            Console.WriteLine("How many lemon would you use to make lemonade?");
            recipe.numberOfLemon = int.Parse(Console.ReadLine());
            if (recipe.numberOfLemon <= inventory.CountLemon())
            {
                return recipe.numberOfLemon;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return LemonUsedToMakeLemonade(recipe, inventory);
            }                               
        }
        //Number of Sugar used to make lemonade
        public static int SugarUsedToMakeLemonade(Recipe recipe, Inventory inventory)
        {
            Console.WriteLine("How many cup of sugar would you use to make lemonade?");
            recipe.numberOfSugar = int.Parse(Console.ReadLine());
            if (recipe.numberOfSugar <= inventory.CountSugar())
            {
                return recipe.numberOfSugar;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return LemonUsedToMakeLemonade(recipe, inventory);
            }
        }
        //Number of Ice cube to make lemonade
        public static int IceCubeUsedToMakeLemonade(Recipe recipe, Inventory inventory)
        {
            Console.WriteLine("How many ice cube would you use to make lemonade?");
            recipe.numberOfIceCube = int.Parse(Console.ReadLine());
            if (recipe.numberOfIceCube <= inventory.CountIceCube())
            {
                return recipe.numberOfIceCube;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return LemonUsedToMakeLemonade(recipe, inventory);
            }
        }

        //Price for a cup of lemonade
        public static decimal PriceFor1CupOfLemonade(Recipe recipe)
        {
            Console.WriteLine("Enter price of your lemonade in cents: $");
            recipe.lemonadePrice = Convert.ToDecimal(Console.ReadLine());
            return recipe.lemonadePrice;
        }


        //Total earning per day
        //player1.soldLemonade
        public static void TotalEarningPerDay(Customer customer, Weather weather, Recipe recipe, Player player, Random random)
        {
            Console.WriteLine("Player earnings for today");
            customer.CustomerBuyingCupOfLemonadeBadWeather(weather, player, random);
            customer.CustomerBuyingCupOfLemonadeFairWeather(weather, player, random);
            customer.CustomerBuyingCupOfLemonadeGoodWeather(weather, player, random);
            customer.CustomerBuyingCupOfLemonadeHighPrice(recipe, player, random);
            customer.CustomerBuyingCupOfLemonadeMediumPrice(recipe, player, random);
            customer.CustomerBuyingCupOfLemonadeLowPrice(recipe, player, random);
            Console.WriteLine("# of cups sale: " + player.soldLemonade);
            Console.WriteLine("# of money sale: " + $"${player.soldLemonade * recipe.lemonadePrice}");
            Console.WriteLine($"Wallet: ${player.wallet.money + (player.soldLemonade * recipe.lemonadePrice)}");
        }
        //Total earnings for 7 days
        public static void TotalEarningPerWeek()
        {
            Console.WriteLine("Player earnings for 7 days report:" + "\n" + "Total Income:" + "\n" + "Total Expenses" + "\n" + "Net Profit or Loss:");
            Console.ReadLine();
        }
        public static bool DetermineIfRestart()
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

