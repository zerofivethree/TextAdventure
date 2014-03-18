using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class concertArea
    {
        /// <summary>
        /// The second stage of the game! The rock concert.
        /// </summary>
        static public void backstage()
        {
            // Backstage at the rock concert
            // Player must first GET BEER x2 to obtain the beer, then GO STAGE to begin the show
            Console.Clear();
            Console.WriteLine("Backstage");
            Console.WriteLine();
            Console.WriteLine("You find yourself backstage at ROCK N ROLL CONCERT.");
            Console.WriteLine("There's lots of bustling people, supermodels, beer, and musical instruments.");
            Console.WriteLine("The ROCKSTAR tells you to get ready to go on stage in 5 minutes.");

            bool beerAccess = false;

            while (true)
            {
                Console.WriteLine();
                Console.Write(">");
                string action = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (action == "look")
                {
                    Console.WriteLine("You are backstage at a rock n roll concert.");
                    Console.WriteLine("There's lots of bustling people, supermodels, beer, and musical instruments.");
                    Console.WriteLine("You see a bottle of GLUE, a bottle of BEER, and the entrance to the STAGE.");
                }
                else if (action == "introspect")
                {
                    Console.WriteLine("You're gonna make it big! Horse David Byrne would be proud!");
                    Console.WriteLine("The rest of your troubles don't seem to matter as much right now, and you like");
                    Console.WriteLine("how that feels. You wish that you could forget about all your life troubles");
                    Console.WriteLine("forever. You wish mom and dad could get back together and be happy again. You");
                    Console.WriteLine("wish people would like you for who you are. You wish you could meet Horse David");
                    Console.WriteLine("Byrne, just once. At least he understands you.");
                }
                else if (action == "look glue" || action == "get glue")
                {
                    Console.WriteLine("...grandpa?");
                }
                else if (action == "get beer" || action == "use beer" || action == "drink beer")
                {
                    if (beerAccess == false)
                    {
                        Console.WriteLine("Nice try, dodongo! You're only thirteen horse years old. This game does not condone underage drinking and won't " +
                            "let you pick it up no matter how many times you try!");
                        beerAccess = true;
                    }
                    else if (beerAccess == true && HorseStats.hasBeer == false)
                    {
                        Console.WriteLine("Despite your horse age, you scoop up the beer when no one's looking.");
                        Console.WriteLine("You'll keep this in your pocket for later.");
                        HorseStats.hasBeer = true;
                        Inventory.addItems("Beer");
                    }
                    else if (beerAccess == true && HorseStats.hasBeer == true)
                    {
                        Console.WriteLine("You already have beer you nincompoop!");
                    }
                }
                else if (action == "go supermodels" || action == "look supermodels" || action == "get supermodels" || action == "call supermodels")
                {
                    Console.WriteLine("They show no interest in your horse body.");
                    Console.WriteLine();
                    Console.WriteLine("You cry a little inside.");
                }
                else if (action == "shred guitar")
                {
                    Console.WriteLine("You manhandle some more schweet licks backstage. The supermodels look over at you!");
                    Console.WriteLine("The ROCKSTAR gives you a thumbs-up from across the way.");
                }
                else if (action == "go stage")
                {
                    if (HorseStats.hasBeer == true)
                    {
                        Console.WriteLine("You head out to the stage.");
                        concertArea.onStage();
                    }
                    else
                    {
                        Console.WriteLine("You're too nervous to go out! If only there was something here to help you out...");
                    }
                }
                else if (action == "call")
                {
                    Console.WriteLine("You can't do that here you nincompoop!");
                }
                else if (action == "argue")
                {
                    // Hidden secret BAD ENDING
                    // Dumps you back to the beginning area, so not a REAL END (no END SCREEN GAME OVER)
                    Console.WriteLine("You get into a huge argument with the band.");
                    Console.WriteLine("Man, you don't need those losers. You'll make it even bigger, with a better band,");
                    Console.WriteLine("and you'll be on the cover of Rolling Stone, and in Coke commercials,");
                    Console.WriteLine("and get a huge suit like Horse David Byrne, and.....");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Ah, screw it. You're going back to the farm.");
                    Console.ReadLine();
                    startingArea.grassyKnoll();
                }
                else if (action == "view inventory" || action == "inventory")
                {
                    Inventory.viewInventory();
                }
                else if (action == "help")
                {
                    Console.WriteLine("Basic commands: look, use, go, get, enter, eat, call, argue, introspect.");
                }
                else if (action == "save" || action == "save game")
                {
                    int area = 2;
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
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("I didn't understand your command! Type \'help\' to view a list of the basic commands.");
                }
            }

        }

        static public void onStage()
        {
            // On stage segment. Player can choose to either crowd surf or perform a solo.
            // Each choice leads to a different ending!
            // Soloing goes to tourBus class.
            // Crowd surfing leads to concertArea.backOnStage where you can either DROP ACID to get a BAD ENDING
            // or perform the SOLO to continue to the tourBus.
            Console.Clear();
            Console.WriteLine("On Stage");
            Console.WriteLine();
            Console.WriteLine("You are now on stage, ready to shred some guitar.");
            Console.WriteLine("The crowd is going crazy! This is your big break! Time to make Horse David Byrne proud!");

            while (true)
            {
                Console.WriteLine();
                Console.Write(">");
                string action = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (action == "look")
                {
                    if (HorseStats.isSurfing == false)
                    {
                        Console.WriteLine("The crowd is hyped up for some music! Better SHRED GUITAR before they rush the stage!");
                    }
                    else
                    {
                        Console.WriteLine("Huh. You look up at the stars in the night sky. You see Pegasus, your great-grandpa, looking down at you.");
                        Console.WriteLine("Now seems like a pretty good time to INTROSPECT.");
                    }
                }
                else if (action == "shred guitar")
                {
                    Console.WriteLine("Woo! Yeah! You're outta your mind tonight!");
                    Console.WriteLine("You're really beginning to regret being in a game with no audio!");
                    Console.WriteLine("The crowd looks like they want you to either CROWD SURF or SHRED a SOLO!");
                    HorseStats.canSurf = true;
                    HorseStats.canShredSolo = true;
                }
                else if (HorseStats.canShredSolo == true && (action == "shred solo" || action == "shred a solo"))
                {
                    Console.WriteLine("WOAWW BWEE! You are going for it!");
                    Console.WriteLine("Ever since the invention of writing, historians have dedicated their lives");
                    Console.WriteLine("to recording the major events of planet Earth. However, it is only now that");
                    Console.WriteLine("they realize the true purpose of technological progress: to record this brilliant");
                    Console.WriteLine("solo. Horse guitar. 2014. Must see. Amazing.");
                    Console.WriteLine();
                    Console.WriteLine("STAR POWER added to inventory!");
                    Inventory.addItems("STAR POWER");
                }
                else if (action == "star power" || action == "use star power" || action == "activate star power")
                {
                    int index = Inventory.inventory.FindIndex(x => x.StartsWith("STAR POWER"));
                    if (index >= 0)
                    {
                        Console.WriteLine("They say after Woodstock, many in attendance wandered aimlessly,");
                        Console.WriteLine("unsure what to do with their lives after having an experience they");
                        Console.WriteLine("knew would never be topped. They were wrong. It was topped.");
                        Console.WriteLine();
                        Console.WriteLine("By a horse.");
                        Console.WriteLine();
                        Console.WriteLine("Right now.");
                        Console.ReadLine();
                        tourBus.inside();
                    }
                    else
                    {
                        Console.WriteLine("You don't have STAR POWER right now! Try shredding a solo to build meter.");
                    }

                }
                else if (HorseStats.canSurf == true && (action == "surf crowd" || action == "crowd surf"))
                {
                    Console.WriteLine("You jump out onto the crowd and go for a crazy ride!");
                    Console.WriteLine("This is entirely too much fun.");
                    Console.ReadLine();
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.WriteLine("Okay, how do you get back to the stage?");
                    HorseStats.isSurfing = true;
                }
                else if (action == "introspect")
                {
                    if (HorseStats.isSurfing == false)
                    {
                        Console.WriteLine("You're way too excited to introspect now!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("                ,, ,,, ,,,, ,,,,,,,,");
                        Console.WriteLine("          /\\        /;; ;;;;;;;;;;;;;; ;;;/ ,;`.   ,,,,");
                        Console.WriteLine("         ;  `-.    /// //////// /////  // ,','`;. ///;;;;,.");
                        Console.WriteLine("        ,'   ,,`-.;;;;;; ;;;;;;; ;;;;// ,' ,'  `.`. ///;;//;,");
                        Console.WriteLine("       ,'   ;;;//////// ////// ///////,'  ,'     ; : ;;// ;//,");
                        Console.WriteLine("`.  ;`;;;;;;;: ;;;;:;; ;:;:;;:;:  ,'     ,' : ;;;;;;;;/,");
                        Console.WriteLine("        `. `; :!::::!;;;;;!::::!;!;;!;:  `.   ,'  ,'///!!;;;;;;");
                        Console.WriteLine("          `._!!;!!!!;!!!!!;!!!!;!;!!;!!`.  `;'  ,'-.!!!//;;;////");
                        Console.WriteLine("             ;   .   .               ,        ,'    ::-!_///;;;;");
                        Console.WriteLine("           .' ,%'  ,%'     `%.   `%.;;   `%.   ;;   ,::  `! ////");
                        Console.WriteLine("          .', '    '    `%,  `:.   `::.   ::  :;    %::    `! ;;");
                        Console.WriteLine("         ,';;        `%, `;;.         `::. `.;;;    `:%   %:///");
                        Console.WriteLine("        ,';;'  ;      ;;  `::;   `%,    ;%:.  ::     ::     %`!/");
                        Console.WriteLine("      ,' ;.'  .%.    ;;    `;;     ;;   ' `;   %     ::    %  :");
                        Console.WriteLine("      :  `;;  %%%    `::   ;;     ;;;      `    `    ::     % `");
                        Console.WriteLine("      ;    ' .%%'  `%  ;   '  ,., `;;         `%,   ::'   %::%");
                        Console.WriteLine("     ;`. `.  %%%%   ;;   .___;;;;  '     `:    `;   ::     :::");
                        Console.WriteLine("     : :  ;  %%%%   ;: ,:' _ `.`.        ;;;   ;;   `::    :::.");
                        Console.WriteLine("     `.;  ;  `%%'  ;;' :: (0) ; :       ::'    ;      ::   `:::");
                        Console.WriteLine("      ,' ;'  %%'  ;;'  ;;.___,',;       ;;    ;;       ;   ,:::");
                        Console.WriteLine(",  ;'  :%:   ;;  ,'------''      ;;;'  .;;            :::'");
                        Console.WriteLine("    ,' ;;   ;%;   ;;  '             ::'    ,;;;            :::");
                        Console.WriteLine("    :  :'   :%:   `;             ;;;;'      ;;             ::%");
                        Console.WriteLine("    :  ;;   :%'   ;;   ;...,,;;''         ;;'    ;     ;   :::");
                        Console.WriteLine("    ;  `;   ::   ;;' ,:::'     .        .;;     ,'    ;;   `;;");
                        Console.WriteLine("    ;  ;'   :: .;;' ,:::'   ,::%.      ;;;    ,'     ;;    ,;;");
                        Console.WriteLine("    : ;;.  .:' ;;' ,:::' ;;:::' ;;    ;;'    ,'    ;;;    ;;;'");
                        Console.WriteLine("     :`;;  ::  ;;  ;;;' '  .    ;;    '  _,-'     ;;;     `;'");
                        Console.WriteLine("     : ;' .:'  ;; .::: ,%'`;   ;;;   _,-'       .;;;'     ;'");
                        Console.WriteLine("    ,' ;; ;;  ;;' :::' ,, .;  ;;  _,' ;      ,;;;'     ,;;'");
                        Console.WriteLine("   .'~~~~~~~~~._ ,;' ,',' ;;  ',-'   ,'    ,';;       ;;;'   ;;;");
                        Console.WriteLine(" ,'             `-.,' .'  ;; ,'     ,' ;;;;;;'       ,;;    ;;;");
                        Console.WriteLine(".';           .    `.,   ;; ,'      ;              ,;;%    ;;;");
                        Console.WriteLine(": ..       _.';     ;   '_,'       .'       ,,,,,,,%;;'    `;;;");
                        Console.WriteLine("`.  .     (_.' .  ;'  ,-'          :  ,,,,,;;;;;;;;;'      .;;;");
                        Console.WriteLine("  `-._        ___,' ,'             :..\"\"\"\"\"`````'        ,;;;;");
                        Console.WriteLine("      `------'____.'               :                   ..;;;;");
                        Console.WriteLine("         `---'                     `.               ..;;;;'");
                        Console.WriteLine("                                    :......:::::::::;;;;'");
                        Console.WriteLine("                                     :::::::::::::::;'      ,;;;");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Wow. Everything is going pretty great. Great granddad is smiling down on you right now!");
                        Console.WriteLine("...and also Horse David Byrne! You're not sure how it happened, but you're suddenly intensely happy.");
                        Console.WriteLine("Life is awesome! The world is a beautiful place and you're no longer afraid to die.");
                        Console.WriteLine("You think you're gonna get back on stage now. It feels like something fell into your INVENTORY.");
                        HorseStats.hasAcid = true;
                        Inventory.addItems("Acid");
                        concertArea.backOnStage();
                    }
                }
                else if (action == "call" || action == "argue")
                {
                    Console.WriteLine("You can't do that here you nincompoop!");
                }
                else if (action == "help")
                {
                    Console.WriteLine("Basic commands: look, use, go, get, enter, eat, call, argue, introspect.");
                }
                else if (action == "save" || action == "save game")
                {
                    int area = 3;
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
                else if (action == "view inventory" || action == "inventory")
                {
                    Inventory.viewInventory();
                }
                else if (action == "quit")
                {
                    Console.WriteLine("Bye.");
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't understand your command! Type \'help\' to view a list of the basic commands.");
                }
            }
        }

        static public void backOnStage()
        {
            Console.Clear();
            Console.WriteLine("You're back on stage and completely in the heat of the moment.");

            while (true)
            {
                Console.WriteLine();
                Console.Write(">");
                string action = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (action == "look")
                {
                    Console.WriteLine("The crowd really wants you to shred a solo right now. But you think there's");
                    Console.WriteLine("something in your inventory that wasn't there before. What should you do?");
                }
                else if (action == "introspect")
                {
                    Console.WriteLine("Who do you think you are, PunPun??? This is no time for introspection!!!");
                }
                else if (action == "use acid" || action == "drop acid" || action == "eat acid")
                {
                    acidTrip.trip();
                }
                else if (HorseStats.canShredSolo == true && (action == "play guitar" || action == "shred guitar"))
                {
                    Console.WriteLine("Hmm...looks like you've already done that.");
                    Console.WriteLine("Perhaps you should try shredding a SOLO.");
                }
                else if (HorseStats.canShredSolo == true && (action == "shred solo" || action == "shred a solo"))
                {
                    Console.WriteLine("WOAWW BWEE! You are going for it!");
                    Console.WriteLine("Ever since the invention of writing, historians have dedicated their lives");
                    Console.WriteLine("to recording the major events of planet Earth. However, it is only now that");
                    Console.WriteLine("they realize the true purpose of technological progress: to record this brilliant");
                    Console.WriteLine("solo. Horse guitar. 2014. Must see. Amazing.");
                    Console.WriteLine();
                    Console.WriteLine("STAR POWER added to inventory!");
                    Inventory.addItems("STAR POWER");
                }
                else if (action == "star power" || action == "use star power" || action == "activate star power")
                {
                    int index = Inventory.inventory.FindIndex(x => x.StartsWith("STAR POWER"));
                    if (index >= 0)
                    {
                        Console.WriteLine("They say after Woodstock, many in attendance wandered aimlessly,");
                        Console.WriteLine("unsure what to do with their lives after having an experience they");
                        Console.WriteLine("knew would never be topped. They were wrong. It was topped.");
                        Console.WriteLine();
                        Console.WriteLine("By a horse.");
                        Console.WriteLine();
                        Console.WriteLine("Right now.");
                        Console.ReadLine();
                        Console.WriteLine("The rest of the night goes by in a blur and you kinda fall asleep at some point...");
                        Console.ReadLine();
                        tourBus.inside();
                    }
                    else
                    {
                        Console.WriteLine("You don't have STAR POWER right now! Try shredding a solo to build meter.");
                    }

                }
                else if (action == "help")
                {
                    Console.WriteLine("Basic commands: look, use, go, get, enter, eat, call, argue, introspect.");
                }
                else if (action == "save" || action == "save game")
                {
                    int area = 4;
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
                else if (action == "view inventory" || action == "inventory")
                {
                    Inventory.viewInventory();
                }
                else if (action == "quit")
                {
                    Console.WriteLine("Bye.");
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't understand your command! Type \'help\' to view a list of the basic commands.");
                }
            }
        }
    }
}