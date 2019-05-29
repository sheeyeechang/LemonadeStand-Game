using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variable (HAS A)//

        Player player1;
        Player player2;
        public int gameMode;

        //constructor (SPAWNER/DEFAULT)//
        public Game()
        {
            gameMode = 0;
        }

        //member method
        public void PlayGame()
        {
            DisplayRules();
        }

        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!" + "\n" + "Your objective is to sell as many cups of lemonade as possible in 7 days." + "\n" + "RULES:" + "\n" + "1. You have a starting budget ($20.00) to operate a lemonade stand." + "\n" + "2. You will choose your recipe for your lemonade that include (lemons, sugar, and ice) and adjust pricing in order to sell the most lemonade." + "\n" + "3. At the beginning of each day, you will be given the week’s forecast and day forecast: bad or fair or good." + "\n" + "4. Based on the weather, you will determine the prices per cup and how many cups of lemonade to make for that day." + "\n" + "5. Demand will depend on the price you set as well as the weather for that day." + "\n" + "6. At the end of each day, you’ll see your daily profit or loss. Play again, and try to beat your high score!");
            Console.ReadLine();
        }

    }
}