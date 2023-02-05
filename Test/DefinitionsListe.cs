using System.Collections.Generic;
namespace Erstellen_eines_Index
{
    internal class DefinitionsListe
    {
        public Dictionary<string, List<string>>
        reihen = new Dictionary<string, List<string>>();
        public void CreateLists()
        {
            reihen.Add("Blume", new List<string>());
            reihen.LastOrDefault().Value.Add("Blatt");
            reihen.LastOrDefault().Value.Add("Stiel");
            reihen.LastOrDefault().Value.Add("Blüte");
            reihen.LastOrDefault().Value.Add("Grün");

            reihen.Add("Baum", new List<string>());
            reihen.LastOrDefault().Value.Add("Stamm");
            reihen.LastOrDefault().Value.Add("Ast");
            reihen.LastOrDefault().Value.Add("Blüte");
            reihen.LastOrDefault().Value.Add("Grün");
            reihen.LastOrDefault().Value.Add("Blatt");

            reihen.Add("Pilz", new List<string>());
            reihen.LastOrDefault().Value.Add("Hut");
            reihen.LastOrDefault().Value.Add("Farbe");
            reihen.LastOrDefault().Value.Add("Stiel");

            //PrintLists(reihen);               

        }

        public void PrintLists()
        {
            foreach (KeyValuePair<string, List<string>> Daten in reihen)
            {
                Console.Write($"{Daten.Key}: ");
                foreach (string Werte in Daten.Value)
                {
                    Console.Write(Werte);
                    if (Werte == Daten.Value.LastOrDefault())
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }

        public Dictionary<string, List<string>>
        index = new Dictionary<string, List<string>>();

        public void CreateIndex()
        {
            foreach (KeyValuePair<string, List<string>> Daten in reihen)
            {
                foreach (string Werte in Daten.Value)
                {
                    if (!index.ContainsKey(Werte))
                    {
                        index[Werte] = new List<string>();
                    }
                    if (!index[Werte].Contains(Daten.Key))
                    {
                        index[Werte].Add(Daten.Key);
                    }
                }
                
            }
        }
        public void PrintIndex()
        {
            Console.WriteLine("\n\n");
            foreach (KeyValuePair<string, List<string>> Daten in index)
            {
                Console.Write($"{Daten.Key}: ");
                foreach (string Werte in Daten.Value)
                {
                    Console.Write(Werte);
                    if (Werte == Daten.Value.LastOrDefault())
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        } 
    }
}