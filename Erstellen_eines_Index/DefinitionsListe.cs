using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace Erstellen_eines_Index
{
    public class DefinitionsListe
    {
        public Dictionary<string, List<string>>
        reihen = new Dictionary<string, List<string>>();
        public void CreateLists()
        {
            var BlumenValues = new List<string>{"Blatt", "Stiel", "Blüte", "Grün"};
            reihen.Add("Blume", BlumenValues);

            var BaumValues = new List<string> { "Stamm", "Ast", "Blüte", "Grün", "Blatt" };
            reihen.Add("Baum", BaumValues);

            var PilzValues = new List<string> { "Hut", "Farbe", "Stiel" };
            reihen.Add("Pilz", PilzValues);
        }

        public string PrintLists()
        {       
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<string, List<string>> rows in reihen)
            {
                tempStringBuilder.Clear();
                tempStringBuilder.Append($"{rows.Key}: ");
                tempStringBuilder.AppendJoin(", ", rows.Value);
                stringBuilder.Append($"{tempStringBuilder}\n");
            }
            return stringBuilder.ToString();
        }

        public Dictionary<string, List<string>>
        index = new Dictionary<string, List<string>>();

        public void CreateIndex()
        {
            foreach (KeyValuePair<string, List<string>> rows in reihen)
            {
                foreach (string values in rows.Value)
                {
                    if (!index.ContainsKey(values))
                    {
                        index[values] = new List<string>();
                    }
                    if (!index[values].Contains(rows.Key))
                    {
                        index[values].Add(rows.Key);
                    }
                }
            }
        }
        public string PrintIndex()
        {
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<string, List<string>> rows in index)
            {
                tempStringBuilder.Clear();
                tempStringBuilder.Append($"{rows.Key}: ");
                tempStringBuilder.AppendJoin(", ", rows.Value);
                stringBuilder.Append($"{tempStringBuilder}\n");
            }
            return stringBuilder.ToString();
        }
    }
}