using System.CodeDom;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        private List<string> inventory = new List<string>();

        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }
        public int GetHealth()
        {
            return Health;
        }

        // adds item to players inventory
        public void PickUpItem(string item)
        {
            inventory.Add(item);
        }

        // returns whats in players inventory
        public string InventoryContents()
        {
            return string.Join("The items you have are , ", inventory);
        }
    }
}
