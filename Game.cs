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
            Room.Room("the room is a dark and damp with cold stone bricks crating the floor, " +
                      "walls and ceiling with nothing but a singular torch for light, " +
                      "as there are no windows the room is bare apart from three exits one to the north " +
                      ",one east and the other west and a rusted dagger on the floor.");
            Console.WriteLine("please input your name, ");
            string playerName = Console.ReadLine();
            Player.Player(playerName, 100);
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here
                bool roomOne = true;
                while (roomOne)
                {
                    bool validNumber = false;
                    while(!validNumber)
                    {
                        Console.WriteLine("you awake to find yourself in a strange room, what would you like to do, " +
                                          "please type the number of the action you would like to preform " +
                                          "1: move north, 2: move east, 3: move south, 4: move west, 5: look around the room " +
                                          "6: view health, 7: pick up item, 8: view inventory,  ");
                        string action = Console.ReadLine();
                        int number;
                        validNumber = int.TryParse(action, out number);
                        if (validNumber)
                        {
                            chosenAction = number;
                        }
                        else
                        {
                            Console.WriteLine("please enter a valid input:  ");
                        }
                        
                    }
                    if (action == 1)
                    {
                        
                    }
                }
            }
        }
    }
}
