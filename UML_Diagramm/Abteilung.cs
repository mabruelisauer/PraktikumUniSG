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

        public void CreateAll(string inputName, int inputMonatsLohn, int inputBonus)
        {
            Angestellter angestellter = new Angestellter(inputName, inputMonatsLohn, inputBonus);
            Manager manager = new Manager(inputName, inputMonatsLohn, inputBonus);
            int Gehalt = manager.GetGehalt();
            LohnKosten += Gehalt;
        }
    }
}
