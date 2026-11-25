using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Console_App
{
    internal class Opdracht4
    {
        private int _bereken(int dag, int maand, int jaar)
        {
            DateTime geboorteDatum = new DateTime(jaar, maand, dag);

            int leeftijd = DateTime.Today.Year - geboorteDatum.Year;

            if (geboorteDatum.Date > DateTime.Today.AddYears(-leeftijd))
            {
                leeftijd--;
            }

            return leeftijd;
        }
        public void Start()
        {
            Console.WriteLine("Opdracht 4!");

            _leeftijd();

        }

        private void _leeftijd()
        {
            int Dag;
            int Maand;
            int Jaar;

            Console.WriteLine("Welke dag ben je geboren?");

            while (!int.TryParse(Console.ReadLine(), out Dag))
            {
                Console.WriteLine("Dat is geen geldig getal! Vul opnieuw je dag in:");
            }
            Console.WriteLine("En welke maand ben je geboren?");

            while (!int.TryParse(Console.ReadLine(), out Maand))
            {
                Console.WriteLine("Dat is geen geldig getal! Vul opnieuw je maand in:");
            }
            Console.WriteLine("En welk jaar?");

            while (!int.TryParse(Console.ReadLine(), out Jaar))
            {
                Console.WriteLine("Dat is geen geldig getal! Vul opnieuw je geboortejaar in:");
            }

            int leeftijd = _bereken(Dag, Maand, Jaar);

            Console.WriteLine("Je bent " + leeftijd + " jaar oud!");

            if (leeftijd >= 18 && leeftijd <= 25)
            {
                Console.WriteLine("Je bent nu een jongvolwassenen, je mag eindelijk stemmen!");
            }
            else if(leeftijd >=26 && leeftijd <=40)
            {
                Console.WriteLine("Al een echte volwassene, jij mag natuurlijk stemmen!");
            }
            else if (leeftijd >= 41 && leeftijd <= 60)
            {
                Console.WriteLine("Volwassene van middelbare leeftijd, jij mag al een tijdje stemmen!");
            }
            else if (leeftijd >= 61 && leeftijd <= 74)
            {
                Console.WriteLine("Een oudere volwassene, je mag nog steeds stemmen hoor!");
            }
            else if (leeftijd >= 75 && leeftijd <= 122)
            {
                Console.WriteLine("Geachte senior, u mag zeker weten stemmen!");
            }
            else if (leeftijd > 122)
            {
                Console.WriteLine("dan ben je het oudste mens dat ooit heeft geleefd, maar jij mag natuurlijk ook stemmen!");
            }
            else
            {
                Console.WriteLine("Je mag nog niet stemmen!");
            }
        }
    }
}