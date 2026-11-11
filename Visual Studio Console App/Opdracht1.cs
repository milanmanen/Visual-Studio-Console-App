using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Console_App
{
    internal class Opdracht1
    {
        public void Start()
        {
            Console.WriteLine("Opdracht 1!");

            Console.WriteLine("Wat is jouw naam?");
            string naam = Console.ReadLine();

            Console.WriteLine("En wat is jouw leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoi " + naam + ", je bent " + leeftijd + " jaar oud!");
        }
    }
}
