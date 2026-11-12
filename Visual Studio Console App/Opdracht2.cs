using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Visual_Studio_Console_App
{
    internal class Opdracht2
    {
        static void SlowWrite(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(45);
            }
            Console.WriteLine();
        }
        public void Start()
        {
            bool opnieuw = true;

            while (opnieuw)
            {
                SlowWrite("Opdracht 2! Make sure to write in all caps just like in the text!");

                SlowWrite("You find yourself in a large dark cave with three different ways to go, one goes LEFT, the other goes STRAIGHT and the last goes RIGHT... Pick your poison.");
                string pad1 = Console.ReadLine();
                if (pad1 == "LEFT")
                {
                    SlowWrite("You enter the left entrance...");
                    SlowWrite("After 2 hours of walking in pure darkness you see light and a door, you can choose to KNOCK on the door, just OPEN it or try the mysterious CRACK on the right.");
                    string pad11 = Console.ReadLine();
                    if (pad11 == "KNOCK")
                    {
                        SlowWrite("You knock on the door...");
                        SlowWrite("A giant man opens the now tiny seeming door and grabs you with one hand. You instantly get crushed.");
                        SlowWrite("GAME OVER how could you have known??");
                        SlowWrite("GAME OVER! Do you want to play again? YES or NO?");
                        string antwoord = Console.ReadLine();

                        if (antwoord == "NO")
                        {
                            opnieuw = false;
                        }
                        else if (antwoord == "YES")
                        {
                            Console.Clear();
                        }
                        else if (pad11 == "OPEN")
                        {
                            SlowWrite("You open the door...");
                            SlowWrite("after walking in the door you now stand in a giant room. after looking around you see a giant man in the corner of the room reading what looks like a cook book.");
                            SlowWrite("Stunned by his size you look around again. You see another DOOR, a big SHOTGUN and a box of MATCHES... or.. you could just TALK to the giant man.");
                            string pad111 = Console.ReadLine();
                            if (pad111 == "DOOR")
                            {
                                SlowWrite("In a panic you hastily open the door and run through.");
                                SlowWrite("Theres a pit with lava right behind the door and you fall in it and die.");
                                SlowWrite("GAME OVER too hasty bro.");
                            }
                            else if (pad111 == "SHOTGUN")
                            {
                                SlowWrite("You pick up the huge shotgun aim it at the giant and without thinking you pull the trigger.");
                                SlowWrite("The shotgun was way too heavy, it blows ur arms off and you bleed out.");
                                SlowWrite("GAME OVER should have went to the gym after all...");
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
                                }
                                else if (pad1111 == "BACK")
                                {
                                    SlowWrite("In a panic you hastily open the door and run through.");
                                    SlowWrite("Theres a pit with lava right behind the door and you fall in it and die.");
                                    SlowWrite("GAME OVER too hasty bro.");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
