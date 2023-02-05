using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagramm
{
    public class Manager : Angestellter
    {
        public int Bonus { get; set; }
        public static int ManagerCount;
        public bool Fehler { get; set; }

        public Manager(string name, int monatsLohn, int bonus) : base (name, monatsLohn)
        {
            if (ManagerCount == 1)
            {
                throw new Exception("You can only have 1 manager!");
            }
            else
            {
                AddManagerCount();
                Name = name;
                MonatsLohn = monatsLohn;
                Bonus = bonus;
            }
        }

        public int GetBonus() { return Bonus; }
        public int GetGehalt(int MonatsLohn)
        {
            int Gehalt = 0;
            Gehalt = MonatsLohn + Bonus;
            return Gehalt;
        }
        public void AddManagerCount()
        {
            ManagerCount += 1;
        }
    }
}
