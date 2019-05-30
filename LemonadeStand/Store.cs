using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        //member variable
        public decimal cupsPrice;
        public decimal lemonPrice;
        public decimal sugarPrice;
        public decimal iceCubePrice;

        //constructor
        public Store()
        {
            cupsPrice = 0.05m;
            lemonPrice = 0.15m;
            sugarPrice = 0.10m;
            iceCubePrice = 0.02m;
        }

        //member method
        //Count price per item
        public decimal CountCupPrice(int NumberOfCupPurchased)
        {
            decimal countCupPrice = cupsPrice * NumberOfCupPurchased;
            return countCupPrice;
        }
        public decimal CountLemonPrice(int NumberOfLemonPurchased)
        {
            decimal countLemonPrice = lemonPrice * NumberOfLemonPurchased;
            return countLemonPrice;
        }
        public decimal CountSugarPrice(int NumberOfSugarPurchased)
        {
            decimal countSugarPrice = sugarPrice * NumberOfSugarPurchased;
            return countSugarPrice;
        }
        public decimal CountIceCubePrice(int NumberOfIceCubePurchased)
        {
            decimal countIceCubePrice = iceCubePrice * NumberOfIceCubePurchased;
            return countIceCubePrice;
        }


    }
}