using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        //member variable
        public string name;

        public Inventory inventory;
        public Wallet wallet;
        public int soldLemonade;
        public decimal totalProfit;

        //constructor
        public Player(int soldLemonade)
        {
            inventory = new Inventory();
            wallet = new Wallet(20.00m);
            this.soldLemonade = soldLemonade;
        }

        //member method

    }
}