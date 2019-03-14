using System;
using System.Collections.Generic;
using System.Linq;
namespace LifeTest
{
    public class Inventory
    {
        public List<Item> Items = new List<Item>();

        public int maxWeight;
        public int currentWeight;

        void AddItem(Item i)
        {
            if (Items.Contains(i)) {
                Console.WriteLine("You already have this item");
            }
            else {
                Items.Add(i);
            }

        }
        void RemoveItem(Item i) { 
            if (Items.Contains(i)) {
                Items.Remove(i);

            }
            else {
                Console.WriteLine("You don't even have this item!");
            }
        }
        public Inventory()
        {
        }
    }
}
