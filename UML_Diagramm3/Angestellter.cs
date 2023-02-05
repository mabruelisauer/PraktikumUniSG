using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagramm
{
    public class Angestellter
    {
        public string Name { get; set; }
        public int MonatsLohn { get; set; }

        public Angestellter(string name, int monatsLohn)
        {
            Name = name;
            MonatsLohn = monatsLohn;
        }

        public int GetMonatsLohn() { return MonatsLohn; }
    }
}
