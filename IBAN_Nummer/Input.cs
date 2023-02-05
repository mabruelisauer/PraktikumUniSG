using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAN_Nummer
{
    internal class Input
    {
        public string GetLändercode()
        {
            Console.WriteLine("Geben sie den Ländercode ein. (z.B. DE)");
            string input = Console.ReadLine();
            return input;
        }
        public int GetPrüfziffer()
        {
            Console.WriteLine("Geben sie die Prüfziffer ein. (Dies sind die erstern 2 Zahlen nach dem Ländercode)");
            int input = Int32.Parse(Console.ReadLine());
            return input;
        }
        public int GetBankleitzahl()
        {
            Console.WriteLine("Geben sie die Bankleitzahl ein. (Dies sind die nächsten 8 Zahlen nach der Prüfziffer)");
            int input = Int32.Parse(Console.ReadLine());
            return input;
        }
        public string GetKontonummer()
        {
            Console.WriteLine("Geben sie die Kontonummer ein. (Dies sind die nächsten 10 Zahlen nach der Bankleitzahl)");
            string input = Console.ReadLine();
            return input;
        }

        public void InputIsValid()
        {
            Console.WriteLine("Die IBAN ist valid");
        }

        public void InputIsInvalid()
        {
            Console.WriteLine("Die IBAN ist nicht valid");
        }
    }
}
