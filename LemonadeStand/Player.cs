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
        public Recipe recipe;
        public Wallet wallet;
        public int soldLemonade;
        public decimal dayEarning;
        public decimal totalEarning;
        public decimal totalProfit;

        public Day day;

        //constructor
        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            wallet = new Wallet(20.00m);
            this.soldLemonade = 0;
            this.dayEarning = 0;

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