using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Runtime.InteropServices;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private Room room2Description;

        public Game()
        {
            // Initialize the game with two rooms and one player adding room descriptions and player name
            currentRoom = new Room("the room is a dark and damp with cold stone bricks creating the floor, " +
                      "walls and ceiling with nothing but a singular torch for light, " +
                      "as there are no windows the room is bare apart from one exit to the north " +
                      ", and a rusted dagger on the floor.");
            room2Description = new Room("this room is much like the one you just came from however there is moor light, " +
                      "and the dead body of the monster now lays on the floor, beside it is waht appears to be a health potion, " +
                      "still with now windows you do notice dried blood near the enterence suggestingvothers came before you " +
                      ", and failed aginst the monster however there are no bodies to be seen.");
            Console.WriteLine("please input your name, ");
            string playerName = Console.ReadLine();

        }
        public void Start()
        {
            // gives object reference for method calls
            // and declares variables for later use
            var Inventory = new Inventory();
            bool playing = true;
            var player = new Player();
            int health = player.GetHealth();
            var potion = new potion();
            string action = ("");
            bool roomOne = true;
            string item = ("rusty dagger");
            bool itemCollected = false;
            var monster = new Monster();
            var Weapon = new Weapon();
            bool roomTwo = true;
            string item2 = ("Health potion");
            bool itemCollected2 = false;
            int monsterHealth = monster.GetHealth();
            int monsterDamage = monster.getMDamage();
            bool dodging = false;
            bool validFightAction = false;
            bool Mdodging = false;
            Random rng = new Random();
            bool monsterFlea = false;
            bool potionUsed = false;

            // outputs beginig statement for game
            Console.WriteLine("you awake to find yourself in a strange room, what would you like to do, " +
    "please type the action you would like to preform ");
            while (playing)
            {
                // declares variables needed in game loop and prints action list for the palyer
 
                Console.WriteLine("please type the action you would like to preform " +
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
                    }
                    else if (action == ("east"))
                    {
                        Console.WriteLine("there is no south door to use please select a different option");
                    }
                    else if (action == ("south"))
                    {
                        Console.WriteLine("there is no south door to use please select a different option");
                    }
                    else if (action == ("west"))
                    {
                        Console.WriteLine("there is no south door to use please select a different option");
                    }
                    else if (action == ("look"))
                    {
                        // assigns the description from room.cs to the description variable
                        string description = currentRoom.GetDescription();
                        Console.WriteLine(description);
                    }
                    else if (action == ("health"))
                    {
                        Console.WriteLine("your health is");
                        Console.WriteLine(health);
                    }
                    else if (action == ("pick"))
                    {
                        // checks if the item has been picked up and only runs method from player.cs if it hasnt
                        if (!itemCollected)
                        {
                            Inventory.AddItem(item);
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
                        string inventoryList = Inventory.GetItems();
                        Console.WriteLine(inventoryList);
                    }
                }




                // room 2
                // checks if the player has weapon and tells user a fight begins
                bool hasWeapon = Inventory.IsWeapon();
                Console.WriteLine("you enter the new room and find a monster prepare to fight, " +
    "please type the action you would like to preform");

                // loops while moster health is above 0 and also loops to ensure a valid action is used
                while (monsterHealth > 0)
                {
                    validFightAction = false;
                    while (!validFightAction)
                    {
                        // gives the user the attack or dodge action
                        Console.WriteLine("attack, dodge");
                        string fightAction = Console.ReadLine();
                        // checks if monster is dodging and checks if the player has a weapon and changes damage and out put message as required
                        if (fightAction == "attack")
                        {
                            if (!Mdodging)
                            {
                                if (hasWeapon)
                                {
                                    int damageDone = Weapon.getAmountDamaged();
                                    Console.WriteLine("you hit the monster with the rusty dagger");
                                    monsterHealth = monsterHealth - damageDone;
                                }
                                else
                                {
                                    Console.WriteLine("you hit the monseter with your fist");
                                    int damageDone = player.GetHandDamage();
                                    monsterHealth = monsterHealth - damageDone;
                                }
                            }
                            // tells user the monster dodged and resets its dodging state to false
                            else
                            {
                                Console.WriteLine("the monster doged your attack");
                                Mdodging = false ;
                            }
                            validFightAction = true;
                        }
                        // sets the players dodge state
                        else if (fightAction == "dodge")
                        {
                            Console.WriteLine("you get ready to doge an attack");
                            dodging = true;
                            validFightAction = true;
                        }
                        else
                        {
                            Console.WriteLine("invalid action please pick another");
                        }
                    }





                    // random select if the monster dodges or attacks and checks if the monseter health is below 30 and gives 1/5 chance for it to run
                    if (monsterHealth < 31)
                    {
                        int MrunChanse = rng.Next(5);
                        if (MrunChanse == 4)
                        {
                            monsterHealth = 0;
                            monsterFlea = true;
                        }

                    }
                    int monsterAction = rng.Next(3);
                    if (monsterAction == 2)
                    {
                    Mdodging = true;
                        Console.WriteLine("the monster does not attack");
                    }
                    else
                    {
                    Console.WriteLine("the monster attacks you with its claws");
                    health = health - monsterDamage;
                    }

                }
                // handles output for if the monster dies or runs away
                if (monsterFlea)
                {
                    Console.WriteLine("the monster ran away");
                }
                else
                {
                    Console.WriteLine("you killed the monster");
                }


                Console.WriteLine(", " +
    "please type the action you would like to preform " +
    "north: move north, east: move east, south: move south, west: move west, look: look around the room, " +
    "health: view health, pick: pick up item, inventory: view inventory, potion: use potion  ");

                // looped so that users can preform multiple actions in one room
                while (roomTwo)
                {
                    bool validAction = false;
                    // reads user input to ensure a valid action was typed and to try again if not
                    while (!validAction)
                    {
                        action = Console.ReadLine();
                        if (action == ("north") || action == ("east") || action == ("south") || action == ("west") || action == ("look") || action == ("health") || action == ("pick") || action == ("inventory") || action == ("potion"))
                        {
                            validAction = true;
                        }
                        else
                        {
                            Console.WriteLine("please input a valid option ");
                        }
                    }


                    // action list that executes needed code for the action selected
                    if (action == ("east"))
                    {
                        Console.WriteLine("you move through the east door");
                        // sets room two to false to end game
                        roomTwo = false;
                        playing = false;
                    }
                    else if (action == ("north"))
                    {
                        Console.WriteLine("there is no south door to use please select a different option");
                    }
                    else if (action == ("south"))
                    {
                        // sets room one to true and room two to false to loop back to the first room
                        Console.WriteLine("you go back through the south door");
                        roomTwo = false;
                        roomOne = true;
                    }
                    else if (action == ("west"))
                    {
                        Console.WriteLine("there is no south door to use please select a different option");
                    }
                    else if (action == ("look"))
                    {
                        // assigns the description from room.cs to the description variable
                        string description = room2Description.GetDescription();
                        Console.WriteLine(description);
                    }
                    else if (action == ("health"))
                    {
                        Console.WriteLine("your health is");
                        Console.WriteLine(health);
                    }
                    else if (action == ("pick"))
                    {
                        // checks if the item has been picked up and only runs method from player.cs if it hasnt
                        if (!itemCollected2)
                        {
                            Inventory.AddItem(item2);
                            itemCollected2 = true;
                            Console.WriteLine("you picked up the health potion");
                        }
                        else
                        {
                            Console.WriteLine("you have already collected the item in this room");
                        }
                    }
                    else if (action == ("inventory"))
                    {
                        // uses method from player.cs to collect and write the players inventory
                        string inventoryList = Inventory.GetItems();
                        Console.WriteLine(inventoryList);
                    }
                    else if (action == ("potion"))
                    {
                        // only allows use if the potion hasnt been used and has been picked up and removes it from the inventory
                        if ((itemCollected2) & (!potionUsed))
                        {
                            Console.WriteLine("you used the health potion and gained 25 health");
                            int healed = potion.getAmountHealed();
                            health = health + healed;
                            Inventory.Remove(item2);
                        }
                        else
                        {
                            Console.WriteLine("you do not have a potion to use");
                        }
                    }
                }



            }
        }
    }
}
