using System;
using System.ComponentModel;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player adding room description and player name with health
            currentRoom = new Room("the room is a dark and damp with cold stone bricks crating the floor, " +
                      "walls and ceiling with nothing but a singular torch for light, " +
                      "as there are no windows the room is bare apart from three exits one to the north " +
                      ",one east and the other west and a rusted dagger on the floor.");
            Console.WriteLine("please input your name, ");
            string playerName = Console.ReadLine();
            player = new Player(playerName, 100);
        }
        public void Start()
        {
            bool playing = true;
            while (playing)
            {
                // declares variables needed in game loop and prints action list for the palyer
                string action = ("");
                bool roomOne = true;
                string item = ("rusty dagger");
                bool itemCollected = false;
                Console.WriteLine("you awake to find yourself in a strange room, what would you like to do, " +
    "please type the action you would like to preform " +
    "north: move north, east: move east, south: move south, west: move west, look: look around the room, " +
    "health: view health, pick: pick up item, inventory: view inventory,  ");

                // looped so that users can preform multiple actions in one room
                while (roomOne)
                {
                    bool validAction = false;
                    // reads user input to ensure a valid action was typed and to try again if not
                    while (!validAction)
                    {
                        action = Console.ReadLine();
                        if (action == ("north") || action == ("east") || action == ("south") || action == ("west") || action == ("look") || action == ("health") || action == ("pick") || action == ("inventory"))
                        {
                            validAction = true;
                        }
                        else
                        {
                            Console.WriteLine("please input a valid option ");
                        }
                    }


                    // action list that executes needed code for the action selected
                    if (action == ("north"))
                    {
                        Console.WriteLine("you move through the north door");
                        // sets both variables to false to end game loop once you leave the room
                        roomOne = false;
                        playing = false;
                    }
                    else if (action == ("east"))
                    {
                        Console.WriteLine("you move through the east door");
                        roomOne = false;
                        playing = false;
                    }
                    else if (action == ("south"))
                    {
                        Console.WriteLine("there is no south door to use please select a different option");
                    }
                    else if (action == ("west"))
                    {
                        Console.WriteLine("you move through the west door");
                        roomOne = false;
                        playing = false;
                    }
                    else if (action == ("look"))
                    {
                        // assigns the description from room.cs to the description variable
                        string description = currentRoom.GetDescription();
                        Console.WriteLine(description);
                    }
                    else if (action == ("health"))
                    {
                        int health = player.GetHealth();
                        Console.WriteLine("your health is :", health);
                    }
                    else if (action == ("pick"))
                    {
                        // checks if the item has been picked up and only runs method from player.cs if it hasnt
                        if (!itemCollected)
                        { 
                            player.PickUpItem(item);
                            itemCollected = true;
                            Console.WriteLine("you picked up the rusty dagger");
                        }
                        else
                        {
                            Console.WriteLine("you have already collected the item in this room");
                        }
                    }
                    else if (action == ("inventory"))
                    {
                        // uses method from player.cs to collect and write the players inventory
                        string inventory = player.InventoryContents();
                        Console.WriteLine(inventory);
                    }
                }
            }
        }
    }
}
