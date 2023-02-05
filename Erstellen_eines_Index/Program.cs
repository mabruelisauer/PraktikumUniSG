using System.Collections.Generic;
namespace Erstellen_eines_Index
{
    public class Program
    {
        static void Main(string[] args)
        {
            DefinitionsListe definitionsListe = new DefinitionsListe();
            definitionsListe.CreateLists();
            string defListeString = definitionsListe.PrintLists();
            Console.WriteLine(defListeString);
            definitionsListe.CreateIndex();
            string indexString = definitionsListe.PrintIndex();
            Console.WriteLine(indexString);
        }
    }
}