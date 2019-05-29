using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        //member varibale

        public List<Lemon> lemonInventory;
        public List<Sugar> sugarInventory;
        public List<IceCube> iceCubeInventory;
        public List<Cup> cupInventory;

        //constructor
        public Inventory()
        {
            lemonInventory = new List<Lemon>() { };
            sugarInventory = new List<Sugar>() { };
            iceCubeInventory = new List<IceCube> { };
            cupInventory = new List<Cup> { };
        }
        //member method

        

    }


}