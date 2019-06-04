using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        //member variable
        public Random random;
        public int cupSale;

        //constructor
        public Customer()
        {
            random = new Random();
        }
        // Bad Weather Sale
        public void CustomerBuyingCupOfLemonadeRainyWeather(Weather weather, Player player, Random random)
        {
            if (weather.currentWeather == "rain")
            {
                int cupSale = random.Next(1, 12);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }
        }
        //Fair Weather Sale
        public void CustomerBuyingCupOfLemonadeCloudyWeather(Weather weather, Player player, Random random)
        {
            if (weather.currentWeather == "cloudy")
            {
                int cupSale = random.Next(1, 8);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }   
                
        }
        // Good Weather Sale
        public void CustomerBuyingCupOfLemonadeSunnyWeather(Weather weather, Player player, Random random)
        {
            if (weather.currentWeather == "sunny")
            {
                int cupSale = random.Next(1, 4);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }
        }
        //High Price Decrease Sales
        public void CustomerBuyingCupOfLemonadeHighPrice(Recipe recipe, Player player, Random random)
        {
            if (recipe.lemonadePrice >= 0.75m)
            {
                int cupSale = random.Next(1, 12);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }                
            }
        }

        //Medium Price Average Sales
        public void CustomerBuyingCupOfLemonadeMediumPrice(Recipe recipe, Player player, Random random)
        {
            if (recipe.lemonadePrice <0.75m && recipe.lemonadePrice > 0.25m)
            {
                int cupSale = random.Next(1, 8);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }
        }

        //Low Price Increase Sale
        public void CustomerBuyingCupOfLemonadeLowPrice(Recipe recipe, Player player, Random random)
        {
            if (recipe.lemonadePrice <= 0.25m)
            {
                int cupSale = random.Next(1, 4);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }
        }


        public void CustomerBuyingCupOfLemonadeLowTemperature(int temperature, Player player, Random random)
        {
            if (temperature <= 70)
            {
                int cupSale = random.Next(1, 12);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }
        }
        //Fair Weather Sale
        public void CustomerBuyingCupOfLemonadeAverageTemperature(int temperature, Player player, Random random)
        {
            if (temperature > 70 && temperature < 85)
            {
                int cupSale = random.Next(1, 8);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }

        }
        // Good Weather Sale
        public void CustomerBuyingCupOfLemonadeHighTemperature(int temperature, Player player, Random random)
        {
            if (temperature >= 85)
            {
                int cupSale = random.Next(1, 4);
                for (int i = 1; i <= cupSale; i++)
                {
                    player.soldLemonade++;
                    player.recipe.numberOfCup--;
                }
            }
        }




    }
}