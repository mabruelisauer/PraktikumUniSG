namespace UML_Diagramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abteilung abteilung = new Abteilung();
            string inputName = "Manuel";
            int inputMonatsLohn = 4577;
            int inputBonus = 1500;
            abteilung.CreateAll(inputName, inputMonatsLohn, inputBonus);
        }
    }
}