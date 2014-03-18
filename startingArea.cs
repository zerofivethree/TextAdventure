using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class startingArea
    {
        /// <summary>
        /// Grassy knoll where the game starts at.
        /// </summary>
        static public void grassyKnoll()
        {
            Console.Clear();
            Console.WriteLine("The Grassy Knoll");
            Console.WriteLine();
            Console.WriteLine("A young horse stands in a field.");
            Console.WriteLine("It just so happens that today, the 15th of March, is this young horse's birthday! Though it was thirteen horse years ago he was born, it is only today that his horse life begins.");
            Console.WriteLine();
            Console.WriteLine("You are the horse. You look around and see some GRASS,");
            Console.WriteLine("a TREE in the distance, and a small puddle of WATER nearby");
            Dictionary<int, bool> gameDict = new Dictionary<int, bool>();
            int grassCounter = 0;

            while (true)
            {
                Console.WriteLine();
                Console.Write(">");
                string action = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (action == "look")
                {
                    Console.WriteLine("You are a horse. You look around and see some GRASS,");
                    Console.WriteLine("a TREE in the distance, and a small puddle of WATER nearby.");
                }
                else if (action == "introspect")
                {
                    Console.WriteLine("You guess that your life is pretty alright. I mean, lots of horses are worse off than you. You did just kind of get over a NASTY BREAKUP with a filly, but life goes on. "
                    + "You are reminded of one of your favorite songs by the band Horse Talking Heads, \'Once in a Horse Lifetime.\' You really wish you could " +
                        "play guitar like Horse David Byrne, but you don't have any money to buy one.");
                }
                else if (action == "eat grass" || action == "use grass")
                {
                    // Grass must be eaten three times in order for GUITAR to become obtainable
                    grassCounter++;
                    if (grassCounter == 1)
                    {
                        Console.WriteLine("You much some leaves of grass! Walt Whitman would be proud.");
                        Console.WriteLine("It still leaves something to be desired...");
                    }
                    else if (grassCounter == 2)
                    {
                        Console.WriteLine("Yum! This patch is really tasty. You scarf it down.");
                    }
                    else if (grassCounter == 3)
                    {
                        HorseStats.ateGrass = true;
                        Console.WriteLine("You nibble at some reasonable-tasting blades. You're getting pretty full.");
                        Console.WriteLine("In the distance, you think you see the sun reflecting off of something...");
                    }
                    else
                    {
                        Console.WriteLine("You're way too full to eat any more grass! But something shiny in the distance");
                        Console.WriteLine("catches your eye.");
                    }

                }
                else if (action == "look tree" || action == "inspect tree")
                {
                    if (HorseStats.ateGrass == false)
                    {
                        Console.WriteLine("It's just a normal tree. There is absolutely nothing special about it, ");
                        Console.WriteLine("and there never will be, no matter how much grass you eat.");
                    }
                    else
                    {
                        Console.WriteLine("What's that? You think you see an electric GUITAR caught in the branches.");
                    }
                }
                else if (HorseStats.ateGrass == true && (action == "get guitar" || action == "get electric guitar"))
                {
                    // Getting the guitar adds it to your inventory, as will getting anything else obtainable in this game.
                    Console.WriteLine("You knock the electric GUITAR out of the tree and pick it up.");
                    Console.WriteLine("Your hooves are surprisingly dextrous at plucking the strings.");
                    Inventory.addItems("Electric GUITAR");
                }
                else if (action == "play guitar" || action == "strum guitar" || action == "use guitar")
                {
                    int index = Inventory.inventory.FindIndex(x => x.StartsWith("Electric GUITAR"));
                    if (index >= 0)
                    {
                        Console.WriteLine("This axe is too badass to do that! The only way to use this");
                        Console.WriteLine("bad boy is to SHRED it.");
                    }
                    else
                    {
                        Console.WriteLine("You silly horse! You don't even have a guitar, and you have no idea");
                        Console.WriteLine("where to get one.");
                    }
                }
                else if (action == "shred guitar")
                {
                    int index = Inventory.inventory.FindIndex(x => x.StartsWith("Electric GUITAR"));
                    if (index >= 0)
                    {
                        HorseStats.shreddedGuitar = true;
                        Console.WriteLine("You assume the powerstance and shred some wicked screamin' licks!");
                        Console.WriteLine("If this game had audio, it would sound really kickass.");
                        Console.WriteLine();
                        Console.WriteLine("You see a LIMO pull up in the distance.");
                        Console.WriteLine("All this shredding appears to have attracted the attention of a passing ROCKSTAR.");
                    }
                    else
                    {
                        Console.WriteLine("Man, you wish you could shred a guitar right now. You can almost feel it");
                        Console.WriteLine("between your hooves, caressing the strings and whammying the whammy bar...");
                        Console.WriteLine();
                        Console.WriteLine("You let out a horse sigh. Man, that would be pretty sweet.");
                    }
                }
                else if (action == "look limo" || action == "look rockstar" || action == "go limo")
                {
                    if (HorseStats.shreddedGuitar == true)
                    {
                        HorseStats.canEnterLimo = true;
                        Console.WriteLine("You gallop over to the limo. \"Hey!\" the rockstar hollers at you, \"I want YOU on tour with me.\"");
                        Console.WriteLine("The door of the limo opens and he motions for you to get in. \"Whaddya say, horse dude?\"");
                    }
                    else if (HorseStats.canEnterLimo == true)
                    {
                        Console.Write("The ROCKSTAR waves at you to get in. \"Yo, dude, just ENTER LIMO, mmkay?\"");
                    }
                    else
                    {
                        Console.WriteLine("You have no idea what you're talking about!");
                    }
                }
                else if (action == "enter limo" || action == "yes")
                {
                    if (HorseStats.canEnterLimo == true)
                    {
                        Console.WriteLine("You climb into the limo next to the famous ROCKSTAR and several SUPERMODELS.");
                        Console.WriteLine("It peels outta there and you're on the road to stardom!");
                        Console.WriteLine();
                        concertArea.backstage();
                    }
                    else
                    {
                        Console.WriteLine("There is no limo here, and you are fairly certain there never will be.");
                    }
                }
                else if (action == "call" || action == "argue")
                {
                    Console.WriteLine("You can't do that here you nincompoop!");
                }
                else if (action == "help")
                {
                    Console.WriteLine("Basic commands: look, use, go, get, enter, eat, call, argue, introspect, inventory.");
                }
                else if (action == "save" || action == "save game")
                {
                    int area = 1;
                    Dictionary<int, bool> gameState = new Dictionary<int, bool>();
                    gameState[0] = HorseStats.ateGrass;
                    gameState[1] = HorseStats.shreddedGuitar;
                    gameState[2] = HorseStats.canEnterLimo;
                    gameState[3] = HorseStats.hasBeer;
                    gameState[4] = HorseStats.canShredSolo;
                    gameState[5] = HorseStats.canSurf;
                    gameState[6] = HorseStats.isSurfing;
                    gameState[7] = HorseStats.hasAcid;
                    gameState[8] = HorseStats.drankBeer;
                    gameState[9] = HorseStats.hasPaper;
                    fileIO.saveGame(area, gameState);
                    Console.WriteLine("Game has been saved.");
                }
                else if (action == "quit")
                {
                    Console.WriteLine("Bye.");
                    break;
                }
                else if (action == "view inventory" || action == "inventory")
                {
                    Inventory.viewInventory();
                }
                else
                {
                    Console.WriteLine("I didn't understand your command! Type \'help\' to view a list of the basic commands.");
                }

            }
        }


    }
}
