using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //place to put made cups of recipe. probably in a list
        public decimal lemonadePrice;
        public int numberOfCup;
        public int numberOfLemon;
        public int numberOfSugar;
        public int numberOfIceCube;



        public Recipe()
        {
            lemonadePrice = 00.00m;
            numberOfCup = 0;
            numberOfLemon = 0;
            numberOfSugar = 0;
            numberOfIceCube = 0;

        }
    }
}
