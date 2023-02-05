using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IBAN_Nummer
{
    internal class Check
    {
        public bool PrüfsummenCheck(string iban)
        {
            iban = InputValidierung(iban);
            //if (!int.TryParse(iban.Remove(0, 2), out int number))
            //{
            //    return false;
            //}
            string Laendererkennung = GetNumLaendererkennung(iban);
            string Pruefziffer = iban.Substring(2, 2);
            string Bban = iban.Remove(0, 4);
            string BbanMitPrüfziffer = iban.Remove(0, 2);
            BigInteger n;
            bool isValid = BigInteger.TryParse(BbanMitPrüfziffer, out n);
            if (!isValid)
            {
                return false;
            }
            string Pruefsumme = Bban + Laendererkennung + Pruefziffer;
            BigInteger numPruefsumme = BigInteger.Parse(Pruefsumme);
            
            return IbanCheck(numPruefsumme);
        }
        public string InputValidierung(string iban)
        {
            string validierteIban = iban.Replace(" ", "");
            return validierteIban;
        }

        public string GetNumLaendererkennung(string AlphaLaendererkennung)
        {
            var Laendererkennung1 = (int)AlphaLaendererkennung[0] - 'A' + 10;
            var Laendererkennung2 = (int)AlphaLaendererkennung[1] - 'A' + 10;
            string numLaendererkennung = $"{Laendererkennung1}{Laendererkennung2}";
            return numLaendererkennung;
        }

        public bool IbanCheck(BigInteger Prüfsumme)
        {
            if (Prüfsumme % 97 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
