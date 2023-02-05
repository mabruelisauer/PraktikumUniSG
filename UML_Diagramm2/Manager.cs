using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagramm
{
    internal class Manager : Angestellter
    {
        public Manager(string Name, int MonatsLohn, int Bonus) : base(Name, MonatsLohn, Bonus)
        {
            
        }

        public int GetBonus() { return Bonus; }
        public int GetGehalt()
        {
            int Gehalt = MonatsLohn + Bonus;
            return Gehalt;
        }
    }
}
