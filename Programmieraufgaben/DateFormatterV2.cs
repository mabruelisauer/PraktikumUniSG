using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieraufgaben
{
    internal class DateFormatterV2
    {
        Date date = new(04, 18, 2008);

        public void formatDate()
        {
            FormatCH();
            FormatUS();
            FormatISO();
        }

        public void FormatCH()
        {
            Console.WriteLine($"CH: {date.Month}.{date.Day}.{date.Year}");
        }
        public void FormatUS()
        {
            Console.WriteLine($"US: {date.Day}/{date.Month}/{date.Year}");
        }
        public void FormatISO()
        {
            Console.WriteLine($"ISO: {date.Year}-{date.Day}-{date.Month}");
        }
    }
}
