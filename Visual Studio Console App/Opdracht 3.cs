using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Console_App
{
    internal class Opdracht3
    {

        public void Start()
        {
            Console.WriteLine("Opdracht 3!");

            Console.WriteLine("Hallo, is het vandaag zonnig, bewolkt of regent het?");
            string weer = Console.ReadLine();
            Console.WriteLine("en wat voor temperatuur is het?");
            int temperatuur;

            while (!int.TryParse(Console.ReadLine(), out temperatuur))
            {
                Console.WriteLine("Dat is geen geldig getal! Vul opnieuw je temperatuur in:");
            }
              if (weer == "zonnig" && temperatuur >= 20)
                {
                    Console.WriteLine("Het is lekker zonnig vandaag je hoeft geen jas te dragen, draag zonnebrand en ga lekker genieten van het weer.");
                }
                else if (weer == "zonnig" && temperatuur < 20)
                {
                    Console.WriteLine("Je hebt wel een jas nodig maar tenminste schijnt het zonnetje neem maar zonnebrand mee voor de zekerheid.");
                }
                else if (weer == "bewolkt" && temperatuur >= 20)
                {
                    Console.WriteLine("Het is lekker weer vandaag je hoeft je niet echt zorgen te maken over de zon of een jas tenzij je het fris krijgt in de schaduw.");
                }
                else if (weer == "bewolkt" && temperatuur < 20 && temperatuur >=10)
                {
                    Console.WriteLine("Het is fris buiten dus doe maar een jas aan, neem voor de zekerheid misschien een paraplu mee.");
                }
                else if (weer == "bewolkt" && temperatuur <10 && temperatuur >0)
                {
                    Console.WriteLine("Brrr het is koud buiten, doe zeker een jas en misschien wanten aan en neem voor de zekerheid een paraplu mee.");
                }
                else if (weer == "bewolkt" && temperatuur <= 0)
                {
                    Console.WriteLine("BRRRR het vriest buiten doe sowieso een jas, wanten, misschien een muts en goeie schoenen aan zodat je niet uitgleidt en lekker warm blijft");
                }
                else if (weer == "regent" || weer == "het regent" || weer == "regen" || weer == "Regent" || weer == "Het regent" || weer == "Regen" && temperatuur >=20)
                {
                    Console.WriteLine("Het is lekker warm maar het regent wel dus een jas hoeft niet maar neem wel een paraplu mee.");
                }
                else if (weer == "regent" || weer == "het regent" || weer == "regen" || weer == "Regent" || weer == "Het regent" || weer == "Regen" && temperatuur <20 && temperatuur >=10)
                {
                    Console.WriteLine("Buiten is het een beetje fris en het regent dus doe een jas aan en neem een paraplu mee.");
                }
                else if (weer == "regent" || weer == "het regent" || weer == "regen" || weer == "Regent" || weer == "Het regent" || weer == "Regen" && temperatuur <10 && temperatuur >0)
                {
                    Console.WriteLine("Brrrrrr Het is koud en het regent ook nog, doe sowieso een jas aan vandaag en neem ook een paraplu. Doe misschien ook wanten aan.");
                }
                else if (weer == "regent" || weer == "het regent" || weer == "regen" || weer == "Regent" || weer == "Het regent" || weer == "Regen" && temperatuur >= 0)
                {
                    Console.WriteLine("BRRRRRRR Het vriest buiten en het regent kijk uit want het kan glad zijn, doe sowieso een jas aan en neem een paraplu mee, daarnaast kan je ook nog wanten en een muts aaandoen.");
                }
            }
        }
    }

