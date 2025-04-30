using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DungeonExplorer
{
    public class Inventory
    {
        // creates lists for item inventory
        List<string> items = new List<string>();
        // method to add items to the inventory
        public void AddItem(string item)
        {
            items.Add(item);
        }
        // method to remove item from inventory
        public void Remove(string item)
        {
            items.Remove(item);
        }
        // methodto return the items in the players inventory
        public string GetItems()
        {
            return string.Join(",", items);
        }
        // sets to array then usses LNIQ to sort for the rusty dagger weapon
        public void FilterWeapons()
        {
            string[] itemsArray = items.ToArray();
            var weapons = from item in itemsArray
                          where item == "rusty dagger"
                          select item;
            foreach (var weapon in weapons)
            {
                Console.WriteLine(weapon);
            }
        }
        // checks to see if the player has a weapon in their inventory and returns answer
        public bool IsWeapon()
        {
            bool weapon = false;
            foreach (string item in items)
            {
                if (item == "rusty dagger")
                {
                    weapon = true;
                }
            }
            return weapon;
        }
    }
}
