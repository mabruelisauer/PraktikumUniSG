using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagramm
{
    internal class Angestellter
    {
        //public Angestellter(string Name, int MonatsLohn)
        //{
        //    this.Name = Name;
        //    this.MonatsLohn = MonatsLohn;
        //}

        //public string Name { get; set; }
        //public int MonatsLohn { get; set; }
        public string Name { get; set; }
        public int MonatsLohn { get; set; }
        public int Bonus { get; set; }

        public Angestellter(string Name, int MonatsLohn, int Bonus)
        {
            this.Name = Name;
            this.MonatsLohn = MonatsLohn;
            this.Bonus = Bonus;
        }
        
        public int GetMonatsLohn() { return MonatsLohn; }
    }
}
