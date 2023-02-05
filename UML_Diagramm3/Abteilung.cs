using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagramm
{
    public class Abteilung
    {
        public int ManagerCount { get; set; }
        public Manager manager; //Aggregation
        public Angestellter angestellter;

        public void CreateManager(string Name, int MonatsLohn, int Bonus)
        {
            if (ManagerCount < 1)
            {
                Manager manager1 = new Manager(Name, MonatsLohn, Bonus);
                ManagerCount++;
            }
        }

        public int LohnKosten { get; set; }

        public void AddToLohnKosten(int Gehalt)
        {
            LohnKosten += Gehalt;
        }

        public int GetLohnKosten()
        {
            return LohnKosten;
        }
    }
}
