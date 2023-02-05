using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagramm
{
    internal class Abteilung
    {
        public int LohnKosten { get; set; }
        public int AnzManager { get; set; }
        public int AnzAngestellter { get; set; }

        public void CreateAll(string inputName, int inputMonatsLohn, int inputBonus)
        {
            Angestellter angestellter = new Angestellter(inputName, inputMonatsLohn, inputBonus);
            Console.WriteLine($"Name des Angestellten: {inputName}   Monatslohn: {inputMonatsLohn}");
            Manager manager = new Manager(inputName, inputMonatsLohn, inputBonus);
            Console.WriteLine($"Name des Managers: {inputName}   Monatslohn: {inputMonatsLohn}");
            int Gehalt = manager.GetGehalt();
            LohnKosten += Gehalt*2;
            AnzManager ++;
            AnzAngestellter ++;
            AddPersons(inputName, inputMonatsLohn, inputBonus, LohnKosten);
            int AnzPersonen = AnzAngestellter + AnzManager;
            Console.Clear();
            Console.WriteLine($"Insgesamt hat diese Abteilung {AnzPersonen} Personen und die entsprechenden Lohnkosten (mit Boni) betragen: {LohnKosten}");
        }
        public void AddPersons(string inputName, int inputMonatsLohn, int inputBonus, int Gehalt)
        {
            int inputNumeric = 0;
            while (inputNumeric != 3)
            {
                Console.WriteLine("\n\nWillst du einen Manager oder Angestellten hinzufügen? \n [1 = Manager, 2 = Angestellter, 3 = Exit]");
                string input = Console.ReadLine();
                while (!Int32.TryParse(input, out int n) || Convert.ToInt32(input) < 0)
                {
                    Console.WriteLine("Input is not valid");
                    input = Console.ReadLine();
                }
                inputNumeric = Convert.ToInt32(input);
                
                if (inputNumeric == 1)
                {
                    Manager manager = new Manager(inputName, inputMonatsLohn, inputBonus);
                    AnzManager++;
                    LohnKosten += inputMonatsLohn + inputBonus;
                    Console.WriteLine($"Name des Managers: {inputName}   Monatslohn: {inputMonatsLohn}");
                }
                else if (inputNumeric == 2)
                {
                    Angestellter angestellter = new Angestellter(inputName, inputMonatsLohn, inputBonus);
                    AnzAngestellter++;
                    LohnKosten += inputMonatsLohn + inputBonus;
                    Console.WriteLine($"Name des Angestellten: {inputName}   Monatslohn: {inputMonatsLohn}");
                }
            }
        }
    }
}
