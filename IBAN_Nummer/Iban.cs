using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAN_Nummer
{
    internal class Iban
    {
        public string Ländercode { get; set; }
        public int Prüfziffer { get; set; }
        public int Bankleitzahl { get; set; }
        public string Kontonummer { get; set; }

        public Iban(string ländercode, int prüfziffer, int bankleitzahl, string kontonummer)
        {
            Ländercode = ländercode;
            Prüfziffer = prüfziffer;
            Bankleitzahl = bankleitzahl;
            Kontonummer = kontonummer;
        }

    }
}
