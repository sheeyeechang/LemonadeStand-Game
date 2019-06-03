using System;

namespace LemonadeStand
{
    public class Game
    {
        //member variable (HAS A)//

        Player player1;
        Player player2;
        public int gameMode;

        Day day;
        public Store store;

        //constructor (SPAWNER/DEFAULT)//
        public Game()
        {
            gameMode = 0;
            day = new Day();
            player1 = new Player();
            store = new Store();

        }

        //member method
        public void PlayGame()
        {
            UserInterface.DisplayRules();

            for (int i = 0; i < 7; i++)
            {
                UserInterface.DaysPlayed(day, i);
                UserInterface.ThisWeekForecast(day.weather, day.dayNames);
                UserInterface.TodayWeather(day.weather);
                UserInterface.WalletToStart(player1, player1.recipe);
                //int playerWallet = UserInterface.WalletToStart(player1);
                //for (int i = 0; i < playerWallet; i++)
                //{
                //    player1.wallet.money -= store.cupsPrice;
                //    player1.wallet.money -= store.lemonPrice;
                //    player1.wallet.money -= store.sugarPrice;
                //    player1.wallet.money -= store.iceCubePrice;
                //}
                UserInterface.DisplayStats(player1);

                int numberOfCups = UserInterface.NumberOfCups();
                while (UserInterface.NotEnoughMoney(player1, (store.cupsPrice * numberOfCups)))
                {
                    numberOfCups = UserInterface.NumberOfCups();
                }
                for (int j = 0; j < numberOfCups; j++)
                {
                    player1.inventory.AddCup();
                    player1.wallet.money -= store.cupsPrice;
                }

                UserInterface.DisplayStats(player1);
                UserInterface.DisplayMoneyCountCup(store, player1, numberOfCups);

                int numberOfLemons = UserInterface.NumberOfLemons();
                while (UserInterface.NotEnoughMoney(player1, (store.lemonPrice * numberOfLemons)))
                {
                    numberOfLemons = UserInterface.NumberOfLemons();
                }               
                for (int j = 0; j < numberOfLemons; j++)
                {
                    player1.inventory.AddLemon();
                    player1.wallet.money -= store.lemonPrice;
                }
                
                UserInterface.DisplayStats(player1);
                UserInterface.DisplayMoneyCountLemon(store, player1, numberOfLemons);

                int numberOfSugars = UserInterface.NumberOfSugars();
                while (UserInterface.NotEnoughMoney(player1, (store.sugarPrice * numberOfSugars)))
                {
                    numberOfSugars = UserInterface.NumberOfSugars();
                }
                for (int j = 0; j < numberOfSugars; j++)
                    {
                        player1.inventory.AddSugar();
                        player1.wallet.money -= store.sugarPrice;
                    }                
                UserInterface.DisplayStats(player1);
                UserInterface.DisplayMoneyCountSugar(store, player1, numberOfSugars);

                int numberOfIceCubes = UserInterface.NumberOfIceCubes();
                while (UserInterface.NotEnoughMoney(player1, (store.iceCubePrice * numberOfIceCubes)))
                {
                    numberOfIceCubes = UserInterface.NumberOfIceCubes();
                }
                for (int j = 0; j < numberOfIceCubes; j++)
                    {
                        player1.inventory.AddIceCube();
                        player1.wallet.money -= store.iceCubePrice;
                    }                
                UserInterface.DisplayStats(player1);
                UserInterface.DisplayMoneyCountIceCube(store, player1, numberOfIceCubes);

                UserInterface.DisplayStats(player1);
                int numberOfCupsUsed = UserInterface.CupUsedToMakeLemonade(player1.recipe, player1.inventory);
                for (int j = 0; j < numberOfCupsUsed; j++)
                {
                    player1.inventory.RemoveCup();
                }

                UserInterface.DisplayStats(player1);
                int numberOfLemonsUsed = UserInterface.LemonUsedToMakeLemonade(player1.recipe, player1.inventory);
                for (int j = 0; j < numberOfLemonsUsed; j++)
                {
                    player1.inventory.RemoveLemon();
                }

                UserInterface.DisplayStats(player1);
                int numberOfSugarUsed = UserInterface.SugarUsedToMakeLemonade(player1.recipe, player1.inventory);
                for (int j = 0; j < numberOfSugarUsed; j++)
                {
                    player1.inventory.RemoveSugar();
                }

                UserInterface.DisplayStats(player1);
                int numberOfIceCubeUsed = UserInterface.IceCubeUsedToMakeLemonade(player1.recipe, player1.inventory);
                for (int j = 0; j < numberOfIceCubeUsed; j++)
                {
                    player1.inventory.RemoveIceCube();
                }

                UserInterface.DisplayStats(player1);
                string lemonadePrice = UserInterface.PriceFor1CupOfLemonade(player1.recipe);
                player1.recipe.lemonadePrice = Convert.ToDecimal(lemonadePrice);

                TotalBuyingCupOfLemonade(day.customer, day.weather, player1.recipe, player1, day.customer.random);
                player1.wallet.money += player1.soldLemonade * player1.recipe.lemonadePrice;

                UserInterface.TellPlayerTotalCupsSoldAndEarningsPerDay(player1.soldLemonade, player1.recipe.lemonadePrice);
                UserInterface.TellPlayerCurrentWalletBalance(player1.wallet.money);
                UserInterface.TellPlayerProfitPerDay(player1.soldLemonade, player1.recipe.lemonadePrice, (store.cupsPrice * numberOfCupsUsed), (store.lemonPrice * numberOfLemonsUsed), (store.sugarPrice * numberOfSugarUsed), (store.iceCubePrice * numberOfIceCubeUsed));

                UserInterface.DisplayStats(player1);

                day.ResetLemonadeSoldPerDay(player1);
            }

            UserInterface.TotalEarningPerWeek(player1.wallet.money);

            bool result = UserInterface.DetermineIfRestart();
            if (result == true)
            {
                PlayGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static void TotalBuyingCupOfLemonade(Customer customer, Weather weather, Recipe recipe, Player player, Random random)
        {
            customer.CustomerBuyingCupOfLemonadeBadWeather(weather, player, random);
            customer.CustomerBuyingCupOfLemonadeFairWeather(weather, player, random);
            customer.CustomerBuyingCupOfLemonadeGoodWeather(weather, player, random);
            customer.CustomerBuyingCupOfLemonadeHighPrice(recipe, player, random);
            customer.CustomerBuyingCupOfLemonadeMediumPrice(recipe, player, random);
            customer.CustomerBuyingCupOfLemonadeLowPrice(recipe, player, random);
        }
    }
}