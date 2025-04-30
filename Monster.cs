using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    // inherets from creature and gets dammage ammount and method
    class Monster : creature
    {
        int MonsterDamage = 15;
        public int getMDamage() 
            { return MonsterDamage; }
    }
}
