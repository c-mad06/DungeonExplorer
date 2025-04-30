using System.CodeDom;
using System.Collections.Generic;

namespace DungeonExplorer
{
    //iherits from creature class with name and regular unarmed damage set
    public class Player : creature
    {
        private string name;

        public string Name { get => name; private set => name = value; }


        int handDamage = 15;
        public int GetHandDamage()
        {
            return handDamage;
        }
        // sets extra health and overides inheritance to include extra health in method call
        int extraHealth = 50;
        public override int GetHealth()
        {
            return extraHealth + health;
        }
    }
}
