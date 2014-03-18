using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class tourBus
    {
        static public void inside()
        {
            /// <summary>
            /// The final stage of the game! Inside the tour bus.
            /// Player can either CALL ROLLING STONE to achieve stardom,
            /// ARGUE with band to break up the band and go back to the farm,
            /// or, if they crowd surfed, DROP ACID to die from a drug overdose.
            /// 
            /// At this point, the game would be more accurately titled ROCK N ROLL SIMULATOR.
            /// </summary>
            Console.Clear();
            Console.WriteLine("Tour Bus");
            Console.WriteLine();
            Console.WriteLine("You wake up in some kinda crappy tour bus. Man, you imagined this thing");
            Console.WriteLine("being way cooler. It's kinda run down and cramped and smelly.");
            Console.WriteLine("You think you see a PHONE, a hungover ROCKSTAR, and a BUCKET HAT.");

            while (true)
            {
                Console.WriteLine();
                Console.Write(">");
                string action = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (action == "look")
                {
                    Console.WriteLine("You're in some kinda crappy tour bus. Man, you imagined this thing");
                    Console.WriteLine("being way cooler. It's kinda run down and cramped and smelly.");
                    Console.WriteLine("You think you see a PHONE, a hungover ROCKSTAR, and a BUCKET HAT.");
                }
                else if (action == "introspect")
                {
                    Console.WriteLine("Last night was pretty amazing. You lived out your lifelong dream");
                    Console.WriteLine("and think you might just have felt happy for the first time in");
                    Console.WriteLine("as long as you can remember. You've left your old life behind.");
                    Console.WriteLine("But part of you still wonders if that was the right decision.");
                    Console.WriteLine();
                    Console.WriteLine("Maybe mom and dad could work something out. If you can live your");
                    Console.WriteLine("dreams of being like Horse David Byrne, anything is possible.");
                    Console.WriteLine();
                    Console.WriteLine("Yet, somehow, living in a functional family still seems like");
                    Console.WriteLine("fantasy...");
                }
                else if (action == "get bucket hat" || action == "use bucket hat" || action == "wear bucket hat")
                {
                    Console.WriteLine("I don't think this would fly for a rock star!");
                    Console.WriteLine("Maybe you should join S A D B O Y S 2 0 0 1 instead...");
                }
                else if (action == "use acid" || action == "drop acid" || action == "eat acid")
                {
                    int index = Inventory.inventory.FindIndex(x => x.StartsWith("Electric GUITAR"));
                    if (index >= 0)
                    {
                        acidTrip.trip();
                    }
                    else
                    {
                        Console.WriteLine("You don't have any acid!");
                        Console.WriteLine("And even if you did, you wouldn't want to start such a destructive");
                        Console.WriteLine("habit now! You saw what happened to grandpa. He was so young...");
                    }
                }
                else if (HorseStats.drankBeer == false && (action == "use beer" || action == "drink beer" || action == "eat beer"))
                {
                    Console.WriteLine("Blech...it's far too early to be hitting the bottle, but you do so anyway.");
                    Console.WriteLine("You forgot that you tend to get pretty argumentative when you're drunk.");
                    Console.WriteLine("You sure hope you don't start an ARGUMENT now! Something bad could happen...");
                    Console.WriteLine("Maybe you'd be better off answering the PHONE");
                    HorseStats.drankBeer = true;
                    int index = Inventory.inventory.FindIndex(x => x.StartsWith("Beer"));
                    Inventory.inventory[index] = "Empty beer bottle";
                }
                else if (HorseStats.drankBeer == true && (action == "argue" || action == "start argument")){
                    Console.WriteLine("You swagger over to the hungover ROCKSTAR on the sofabed.");
                    Console.WriteLine("\"This band sucks!\" you yell \"I do all the work! I'm all the talent!\"");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("He looks at you with a grimace. \"Then I guess you don't need us.\"");
                    Console.WriteLine("He gives you the finger and tells you to shove off.");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("You guess you'll go back to the grassy knoll.");
                    grassyKnoll.goodEnd();
                }
                else if (HorseStats.drankBeer == false && (action == "argue" || action == "start argument"))
                {
                    Console.WriteLine("Man, you don't got it in you to do that now. Maybe if you");
                    Console.WriteLine("had a little something to drink. You tend to get pretty");
                    Console.WriteLine("argumentative when you're drunk.");
                    Console.WriteLine();
                    Console.WriteLine("Not that you've been drunk before. You're only 13 horse years old.");
                }
                else if (action == "look phone" || action == "go phone")
                {
                    Console.WriteLine("You saunter on over to the phone. It's an old rotary piece");
                    Console.WriteLine("that somehow still works, despite being in an RV.");
                    Console.WriteLine("I mean, you're a horse, things like this aren't all that surprising.");
                    Console.WriteLine();
                    Console.WriteLine("You think you see a scrap of PAPER with a phone number on it.");
                }
                else if (HorseStats.hasPaper == false && (action == "look paper" || action == "get paper"))
                {
                    Console.WriteLine("RLG STONE 555-867-5309");
                    Inventory.addItems("Paper");
                    HorseStats.hasPaper = true;
                    Console.WriteLine();
                    Console.WriteLine("Paper was added to your inventory.");
                }
                else if (HorseStats.hasPaper == true && (action == "look paper" || action == "paper"))
                {
                    Console.WriteLine("RLG STONE 555-867-5309");
                }
                else if (action == "use phone" || action == "call")
                {
                    Console.WriteLine("Enter phone number to call: ");
                    string phoneNumber = Console.ReadLine();
                    if (phoneNumber == "555-867-5309" || phoneNumber == "5558675309")
                    {
                        phoneCall.goodEnding();
                    }
                    else
                    {
                        Console.WriteLine("It rings for like 10 minutes before you realize");
                        Console.WriteLine("they probably aren't picking up.");
                        Console.WriteLine();
                        Console.WriteLine("Is this thing even connected?");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("Actually, how did you even dial this thing with hooves?");
                        // the same way you played guitar, you silly horse
                    }
                }
                else if (action == "help")
                {
                    Console.WriteLine("Basic commands: look, use, go, get, enter, eat, call, argue, introspect, inventory.");
                }
                else if (action == "save" || action == "save game")
                {
                    int area = 5;
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
