using System.Text.RegularExpressions;

namespace IBAN_Nummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check check = new Check();
            //CH68 8080 8002 6457 2655 1
            if (check.PrüfsummenCheck("GR0801721935131548796482667"))
            {
                Console.WriteLine("Die IBAN ist korrekt");
            }
            else
            {
                Console.WriteLine("Die IBAN ist ungültig");
            }
        }
    }
}