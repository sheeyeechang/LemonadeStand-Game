using System;

namespace LemonadeStand
{
    public class Game
    {
        //member variable (HAS A)//
        UserInterface userInterface;

        Player player1;
        Player player2;
        public int gameMode;

        Day day;
        Store store;

        //constructor (SPAWNER/DEFAULT)//
        public Game()
        {
            gameMode = 0;
            userInterface = new UserInterface();
            day = new Day();
            player1 = new Player();
            store = new Store();
            
        }

        //member method
        public void PlayGame()
        {
            userInterface.DisplayRules();
            userInterface.ThisWeekForecast(day.weather, day.dayNames);
            userInterface.TodayWeather(day.weather);
            userInterface.DaysPlayed(day, day.dayName);       
            for (int i = 0; i < 7; i++)
            {
                player1.day.CurrentDay(day.dayName);
            }
            userInterface.WalletToStart(player1);
            int numberOfCups = userInterface.NumberOfCups();
            for (int i = 0; i < numberOfCups; i++)
            {
                player1.inventory.AddCup();
                player1.wallet.money -= store.cupsPrice;
            }           
            int numberOfLemons = userInterface.NumberOfLemons();
            for (int i = 0; i < numberOfLemons; i++)
            {
                player1.inventory.AddLemon();
                player1.wallet.money -= store.lemonPrice;
            }
            int numberOfSugars = userInterface.NumberOfSugars();
            for (int i = 0; i < numberOfSugars; i++)
            {
                player1.inventory.AddSugar();
                player1.wallet.money -= store.sugarPrice;
            }
            userInterface.NumberOfIceCubes();
            userInterface.PriceFor1CupOfLemonade();
            userInterface.TotalEarningPerWeek();

            bool result = userInterface.DetermineIfRestart();
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