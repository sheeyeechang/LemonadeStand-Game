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

        //constructor (SPAWNER/DEFAULT)//
        public Game()
        {
            gameMode = 0;
            userInterface = new UserInterface();
            day = new Day();
        }

        //member method
        public void PlayGame()
        {
            userInterface.DisplayRules();
            userInterface.ThisWeekForecast(day.weather, day.dayNames);
            userInterface.TodayWeather(day.weather);
            userInterface.DaysPlayed(day, day.dayName);
                //{
                //for (int i = 0; i < 7; i++);
                //}
            userInterface.NumberOfCups();
            userInterface.NumberOfLemons();
            userInterface.NumberOfSugar();
            userInterface.NumberOfIceCube();
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