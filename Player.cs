using System.CodeDom;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player : creature
    {
        private string name;

        public string Name { get => name; private set => name = value; }


        int handDamage = 15;
        public int GetHandDamage()
        {
            return handDamage;
        }
        int extraHealth = 50;
        public override int GetHealth()
        {
            return extraHealth + health;
        }
    }
}
