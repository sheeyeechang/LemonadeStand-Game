using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        //member varibale

        public List<Cup> cupInventory = new List<Cup>() { };
        public List<Lemon> lemonInventory = new List<Lemon>() { };
        public List<Sugar> sugarInventory = new List<Sugar>() { };
        public List<IceCube> iceCubeInventory = new List<IceCube>() { };

        Cup cup = new Cup();
        Lemon lemon = new Lemon();
        Sugar sugar = new Sugar();
        IceCube iceCube = new IceCube();

        //constructor
        public Inventory()
        {
            
        }
        //member method
        //Cups in inventory: 0
        //Lemons in inventory: 0
        //Sugar in inventory: 0
        //Ice cubes in inventory: 0

        //ADD inventory
        public void AddCup()
        {    
            cupInventory.Add(cup);
        }
        public void AddLemon()
        {
            lemonInventory.Add(lemon);
        }
        public void AddSugar()
        {
            sugarInventory.Add(sugar);
        }
        public void AddIceCube()
        {
            iceCubeInventory.Add(iceCube);
        }
        //REMOVE inventory
        public int RemoveCup()
        {                
            cupInventory.Remove(cup);
            int numberCup = cupInventory.Count;
            return numberCup;
        }
        public int RemoveLemon()
        {
            lemonInventory.Remove(lemon);
            int numberLemon = lemonInventory.Count;
            return numberLemon;
        }
        public int RemoveSugar()
        {
            sugarInventory.Remove(sugar);
            int numberLemon = lemonInventory.Count;
            return numberLemon;
        }
        public int RemoveIceCube()
        {
            iceCubeInventory.RemoveAt(0);
            int numberLemon = lemonInventory.Count;
            return numberLemon;
        }
        //COUNT inventory
        public int CountCup()
        {
            int countCups = cupInventory.Count();
            return countCups;
        }
        public int CountLemon()
        {
            int countLemon = lemonInventory.Count();
            return countLemon;
        }
        public int CountSugar()
        {
            int countSugar = sugarInventory.Count();
            return countSugar;
        }
        public int CountIceCube()
        {
            int countIceCube = iceCubeInventory.Count();
            return countIceCube;
        }

    }
}