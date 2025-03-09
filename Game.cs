using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player
            Room.Room("the room is a dark and damp with cold stone bricks crating the floor, walls and ceiling with nothing but a singular torch for light, as there are no windows the room is bare apart from three exits one to the north ,one east and the other west.");
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = false;
            while (playing)
            {
                // Code your playing logic here
            }
        }
    }
}
