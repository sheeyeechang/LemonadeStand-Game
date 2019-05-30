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

        public Day day;

        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet(20.00m);
            this.soldLemonade = 0;

            day = new Day();
        }

        //member method

        //public int Wallet
        //{
        //    get => wallet;
        //    set => wallet;

        //}
    }
}