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
        List<string> items = new List<string>();
        public void AddItem(string item)
        {
            items.Add(item);
        }
        public void Remove(string item)
        {
            items.Remove(item);
        }
        public string GetItems()
        {
            return string.Join(",", items);
        }
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
