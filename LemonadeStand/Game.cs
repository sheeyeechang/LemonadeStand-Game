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
            UserInterface.ThisWeekForecast(day.weather, day.dayNames);
            UserInterface.TodayWeather(day.weather);
            UserInterface.DaysPlayed(day, day.dayName);       
            for (int i = 0; i < 7; i++)
            {
                player1.day.CurrentDay(day.dayName);
            }
            UserInterface.WalletToStart(player1);
            //int playerWallet = UserInterface.WalletToStart(player1);
            //for (int i = 0; i < playerWallet; i++)
            //{
            //    player1.wallet.money -= store.cupsPrice;
            //    player1.wallet.money -= store.lemonPrice;
            //    player1.wallet.money -= store.sugarPrice;
            //    player1.wallet.money -= store.iceCubePrice;
            //}

            int numberOfCups = UserInterface.NumberOfCups();
            for (int i = 0; i < numberOfCups; i++)
            {
                player1.inventory.AddCup();
                if (UserInterface.NotEnoughMoney(player1) == true)
                {
                    break;
                }
                //player1.wallet.money -= store.cupsPrice;
            }
            UserInterface.DisplayStats(player1);
            UserInterface.DisplayMoneyCountCup(store, player1, numberOfCups);

            int numberOfLemons = UserInterface.NumberOfLemons();
            for (int i = 0; i < numberOfLemons; i++)
            {
                player1.inventory.AddLemon();
                if (UserInterface.NotEnoughMoney(player1) == true)
                {
                    break;
                }
                //player1.wallet.money -= store.lemonPrice;
            }
            UserInterface.DisplayStats(player1);
            UserInterface.DisplayMoneyCountLemon(store, player1, numberOfLemons);

            int numberOfSugars = UserInterface.NumberOfSugars();
            for (int i = 0; i < numberOfSugars; i++)
            {
                player1.inventory.AddSugar();
                if (UserInterface.NotEnoughMoney(player1) == true)
                {
                    break;
                }
                //player1.wallet.money -= store.sugarPrice;
            }
            UserInterface.DisplayStats(player1);
            UserInterface.DisplayMoneyCountSugar(store, player1, numberOfSugars);

            int numberOfIceCubes = UserInterface.NumberOfIceCubes();
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                player1.inventory.AddIceCube();
                if (UserInterface.NotEnoughMoney(player1) == true)
                {
                    break;
                }
                //player1.wallet.money -= store.iceCubePrice;
            }
            UserInterface.DisplayStats(player1);
            UserInterface.DisplayMoneyCountIceCube(store, player1, numberOfIceCubes);

            UserInterface.DisplayStats(player1);
            int numberOfCupsUsed = UserInterface.CupUsedToMakeLemonade(player1.inventory);
            for (int i = 0; i < numberOfCupsUsed; i++)
            {
                player1.inventory.RemoveCup();
            }

            UserInterface.DisplayStats(player1);
            int numberOfLemonsUsed = UserInterface.LemonUsedToMakeLemonade(player1.inventory);
            for (int i = 0; i < numberOfLemonsUsed; i++)
            {
                player1.inventory.RemoveLemon();
            }

            UserInterface.DisplayStats(player1);
            int numberOfSugarUsed = UserInterface.SugarUsedToMakeLemonade(player1.inventory);
            for (int i = 0; i < numberOfSugarUsed; i++)
            {
                player1.inventory.RemoveSugar();
            }

            UserInterface.DisplayStats(player1);
            int numberOfIceCubeUsed = UserInterface.IceCubeUsedToMakeLemonade(player1.inventory);
            for (int i = 0; i < numberOfIceCubeUsed; i++)
            {
                player1.inventory.RemoveIceCube();
            }

            UserInterface.PriceFor1CupOfLemonade();

            UserInterface.DisplayStats(player1);
            UserInterface.TotalEarningPerWeek();

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
    }
}