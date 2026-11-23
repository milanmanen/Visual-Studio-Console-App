using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Visual_Studio_Console_App
{
    internal class Opdracht2
    {
        bool opnieuw = true;
        string antwoord;
        static void SlowWrite(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }

        private void _again()
        {
            SlowWrite("GAME OVER! Do you want to play again? YES or NO?");
            antwoord = Console.ReadLine();

            if (antwoord == "NO")
            {
                opnieuw = false;
            }
            else if (antwoord == "YES")
            {
                Console.Clear();
            }
        }

        private void _won()
        {
            SlowWrite("You finally see daylight, congratulations you win. Do you want to play again and uncover more endings? YES or NO?");
            antwoord = Console.ReadLine();

            if (antwoord == "NO")
            {
                opnieuw = false;
            }
            else if (antwoord == "YES")
            {
                Console.Clear();
            }
        }
        private void _cave()
        {
            SlowWrite("You find yourself in a large dark cave with three different ways to go, one goes LEFT, the other goes STRAIGHT and the last goes RIGHT... Pick your poison.");
            string pad1 = Console.ReadLine();
            if (pad1 == "LEFT")
            {
                void LEFT()
                {
                    SlowWrite("You enter the left entrance...");
                    SlowWrite("After 2 hours of walking in pure darkness you see light and a door.");
                    SlowWrite("you can choose to go BACK, KNOCK on the door, just OPEN it or try the mysterious CRACK on the right.");
                    string pad11 = Console.ReadLine();
                    if (pad11 == "BACK")
                    {
                        _cave();
                    }
                    else if (pad11 == "KNOCK")
                    {
                        SlowWrite("You knock on the door...");
                        SlowWrite("A giant man opens the now tiny seeming door and grabs you with one hand. You instantly get crushed.");
                        SlowWrite("GAME OVER how could you have known??");
                        _again();
                    }
                    else if (pad11 == "OPEN")
                    {
                        void OPEN()
                        {
                            SlowWrite("You open the door...");
                            SlowWrite("after walking in the door you now stand in a giant room. after looking around you see a giant man in the corner of the room reading what looks like a cook book.");
                            SlowWrite("Stunned by his size you look around again. Your instincts are telling you to go BACK but you see another DOOR, a big SHOTGUN and a box of MATCHES... or.. you could just TALK to the giant man.");
                            string pad111 = Console.ReadLine();
                            if (pad111 == "DOOR")
                            {
                                SlowWrite("In a panic you hastily open the door and run through.");
                                SlowWrite("Theres a pit with lava right behind the door and you fall in it and die.");
                                SlowWrite("GAME OVER too hasty bro.");
                                _again();
                            }
                            else if (pad111 == "BACK")
                            {
                                LEFT();
                            }
                            else if (pad111 == "SHOTGUN")
                            {
                                SlowWrite("You pick up the huge shotgun aim it at the giant and without thinking you pull the trigger.");
                                SlowWrite("The shotgun was way too heavy, it blows ur arms off and you bleed out.");
                                SlowWrite("GAME OVER should have went to the gym after all...");
                                _again();
                            }
                            else if (pad111 == "MATCHES")
                            {
                                SlowWrite("You grab the box of matches and light the entire house on fire.");
                                SlowWrite("Quick! you have to run you can either go back through the FRONT door or run through to the BACK door.");
                                string pad1111 = Console.ReadLine();
                                if (pad1111 == "FRONT")
                                {
                                    SlowWrite("You quickly run back to the cave where you came from but the giant man cant escape the house becuase he made his doors to small.. he dies.");
                                    SlowWrite("Feeling depressed from guilt you run back and burn yourself alive together with the giant man.");
                                    SlowWrite("GAME OVER atleast you still had your humanity i guess..");
                                    _again();
                                }
                                else if (pad1111 == "BACK")
                                {
                                    SlowWrite("In a panic you hastily open the door and run through.");
                                    SlowWrite("Theres a pit with lava right behind the door and you fall in it and die.");
                                    SlowWrite("GAME OVER too hasty bro.");
                                    _again();
                                }
                            }
                            else if (pad111 == "TALK")
                            {
                                SlowWrite("You approach the giant man and say hey.");
                                SlowWrite("The giant man gets startled and hastily turns around, his pants are off and hes blushing then he tells you that if you dont tell anyone what happened here he'll lead you to the exit of the cave.");
                                SlowWrite("you agree to not tell anyone and he leads you to the exit");
                                _won();
                            }
                        }
                        OPEN();
                    }
                    else if (pad11 == "CRACK")
                    {
                        SlowWrite("You crawl through the crack.");
                        SlowWrite("On the other side of the of the crack you find a treasure, you take a gold coin.");
                        SlowWrite("you get crushed by a boulder the moment you put the coin in your pocket.");
                        SlowWrite("GAME OVER did you learn nothing from movies?");
                        _again();
                    }
                }
                LEFT();
            }
            else if (pad1 == "STRAIGHT")
            {
                void STRAIGHT()
                {
                    SlowWrite("You decide to go into the middle path.");
                    SlowWrite("You see the exit of the cave and daylight but before that you can choose to go BACK if you want to for some reason.. There is 3 different paths one is PARKOUR the other is a PUZZLE and the last is a RIDDLE.");
                    string pad12 = Console.ReadLine();
                    if (pad12 == "PARKOUR")
                    {
                        SlowWrite("You decide to test your athletics by trying to complete the parkour. do you trust them? if not you can still choose to go BACK, else type anything");
                        string parkourBack = Console.ReadLine();
                        if (parkourBack == "BACK")
                        {
                            STRAIGHT();
                        }
                        else
                        {
                            SlowWrite("unfortunately you're a out of shape gamer and you fall into a deep hole and splat on the ground.");
                            SlowWrite("GAME OVER i promise it wasnt targeted.");
                            _again();
                        }
                    }
                    else if (pad12 == "BACK")
                    {
                        _cave();
                    }
                    else if (pad12 == "PUZZLE")
                    {
                        SlowWrite("You decide to try your luck on the puzzle.");
                        SlowWrite("Infront of you there are 3 switches ONE, TWO and THREE, one of these switches will make the bridge extend and you will be able to cross, you are only allowed to pick once and you cant see if the bridge has been extended before you get there. Or go BACK if u still dont trust it...");
                        string pad121 = Console.ReadLine();
                        if (pad121 == "ONE")
                        {
                            SlowWrite("You picked the most obvious and the first one.");
                            SlowWrite("You take place in the cart and it starts to roll you to the bridge.");
                            SlowWrite("YOU PICKED WRONG the cart starts falling and crashes on the ground.");
                            SlowWrite("GAME OVER it was a 1 in 3 chance, very unlucky.");
                            _again();
                        }
                        else if (pad121 == "BACK")
                        {
                            STRAIGHT();
                        }
                        else if (pad121 == "TWO")
                        {
                            SlowWrite("You think the middle lever is the savest option.");
                            SlowWrite("You take your place in the cart and start rolling toward the bridge.");
                            SlowWrite("YOU PICKED RIGHT you look infront of you and you see the bridge towards the daylight fully extended.");
                            SlowWrite("still in the cart you roll outside into freedom.");
                            _won();
                        }
                        else if (pad121 == "THREE")
                        {
                            SlowWrite("You for some reason pick the last one.");
                            SlowWrite("You take place in the cart and it starts to roll you to the bridge.");
                            SlowWrite("YOU PICKED WRONG the cart starts falling and crashes on the ground.");
                            SlowWrite("GAME OVER! it was a 1 in 3 chance, very unlucky.");
                            _again();
                        }
                    }
                    else if (pad12 == "RIDDLE")
                    {
                        void RIDDLE()
                        {
                            SlowWrite("You trust your brain to get you through this.");
                            SlowWrite("You walk into a side room, on the wall there's a riddle: What do you call a sleeping bull?");
                            SlowWrite("A : a bulldozer B : a snoring cow C : a lazy steak, if u doubt your brains to get you through this you can still go BACK");
                            string pad122 = Console.ReadLine();
                            if (pad122 == "A")
                            {
                                SlowWrite("You pick A, was it a guess?");
                                SlowWrite("CORRECT! A bridge to freedom extends and you walk into daylight.");
                                _won();
                            }
                            else if (pad122 == "BACK")
                            {
                                STRAIGHT();
                            }
                            else if (pad122 == "B")
                            {
                                SlowWrite("You pick B, was it a guess?");
                                SlowWrite("WRONG! The whole room EXPLODES.");
                                SlowWrite("GAME OVER! It was a good guess.");
                                _again();
                            }
                            else if (pad122 == "C")
                            {
                                SlowWrite("You pick C, was it a guess?");
                                SlowWrite("WRONG! The whole room EXPLODES.");
                                SlowWrite("GAME OVER! It was a good guess.");
                                _again();
                            }
                        }
                        RIDDLE();
                    }
                }
                STRAIGHT();
            }
            else if (pad1 == "RIGHT")
            {
                SlowWrite("You decide to go into the path leading to the right.");
                SlowWrite("The path is very tight and narrow. do you want to go BACK instead? else type anything");
                string rightBack = Console.ReadLine();
                if (rightBack == "BACK")
                {
                    _cave();
                }
                else
                {
                    SlowWrite("You get stuck and no one comes to help you.");
                    SlowWrite("GAME OVER! Dead at the first option?? How unfair...");
                    _again();
                }
            }
        }



        public void Start()
        { 

            while (opnieuw)
            {
                SlowWrite("Opdracht 2! Make sure to write in all caps just like in the text!");

                _cave(); 
            }
        }
    }
}
