using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    // sets ammount healed and damaged by items
    public class Items
    {
        public int damageItem = 35;
        public int healthItem = 25;
    }

    // inherits item class and returns damage
    class Weapon : Items
    {
        public int getAmountDamaged()
        {
            return damageItem;
        }
    }
    //inherits item class and returns health given
    class potion : Items
    {
        public int getAmountHealed()
        {
            return healthItem;
        }
    }

    interface ICollectable
    {
        

    }

}
