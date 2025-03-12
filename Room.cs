namespace DungeonExplorer
{
    public class Room
    {
        private string description;

        public Room(string description)
        {
            this.description = description;
        }

        // creates method for returning room description
        public string GetDescription()
        {
            return description;
        }
    }
}