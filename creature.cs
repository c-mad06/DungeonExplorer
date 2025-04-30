using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    // sets health and method for gathering health to be inhereted
    public abstract class creature
    {
        public int health = 100;
        public virtual int GetHealth()
        {
            return health;
        }
    }
}
