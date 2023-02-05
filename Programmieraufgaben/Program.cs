using Datumsformatierung;

namespace Programmieraufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input input = new Input();
            Date date = new Date(18, 04, 2008);
            DateformatterV3 dateFormatter = new DateformatterV3();
            Console.WriteLine(dateFormatter.GetFormat(date, "US"));
            //Console.WriteLine("Enter GetFormat [CH, US, ISO]");
            //dateFormatter.formatDate(input.GetFormat());
            //DateFormatterV2 dateFormatter = new DateFormatterV2();
            //dateFormatter.formatDate();
        }
    }
}