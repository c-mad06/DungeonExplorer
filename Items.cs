using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Items
    {
        public int damageItem = 35;
        public int healthItem = 25;
    }

    class Weapon : Items
    {
        public int getAmountDamaged()
        {
            return damageItem;
        }
    }

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
