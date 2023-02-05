using System.Collections.Generic;
namespace Erstellen_eines_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<DefinitionsListe>();

            //list.Add(new DefinitionsListe()
            //{
            //    Key = "Blume",
            //    Values = new List<string>()
            //    {
            //        "Blatt", "Stil", "Blüte", "Grün"
            //    }
            //});

            //list.Add(new DefinitionsListe()
            //{
            //    Key = "Baum",
            //    Values = new List<string>()
            //    {
            //        "Stamm", "Ast", "Blüte", "Grün", "Blatt"
            //    }
            //});

            //list.Add(new DefinitionsListe()
            //{
            //    Key = "Pilz",
            //    Values = new List<string>()
            //    {
            //        "Hut", "Farbe", "Stiel"
            //    }
            //});

            //list.Add(new DefinitionsListe()
            //{
            //    Key = "Tisch",
            //    Values = new List<string>()
            //    {
            //        "Holz", "Beine"
            //    }
            //});

            //list.Add(new DefinitionsListe()
            //{
            //    Key = "Schrank",
            //    Values = new List<string>()
            //    {
            //        "Holz", "Tür"
            //    }
            //});

            //list.Add(new DefinitionsListe()
            //{
            //    Key = "Stuhl",
            //    Values = new List<string>()
            //    {
            //        "Lehne", "Beine", "Sitzfläche"
            //    }
            //});

            //list.Add(new DefinitionsListe()
            //{
            //    Key = "Bett",
            //    Values = new List<string>()
            //    {
            //        "Holz", "Beine", "Laken"
            //    }
            //});
            DefinitionsListe definitionsListe = new DefinitionsListe();
            definitionsListe.CreateLists();
            definitionsListe.PrintLists();
            definitionsListe.CreateIndex();
            definitionsListe.PrintIndex();
            //var collection = new List<Container>()
        }
    }
}