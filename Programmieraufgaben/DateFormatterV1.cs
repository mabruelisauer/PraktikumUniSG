using Datumsformatierung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieraufgaben
{
    internal class DateFormatterV1
    {
        public string formatDate(string format)
        {
            if (format == "CH")
            {
                FormatCH();
            }
            else if (format == "US")
            {
                FormatUS();
            }
            else if (format == "ISO")
            {
                FormatISO();
            }
            return "";
        }

        Input input = new Input();

        private static int DayF;
        private static int MonthF;
        private static int YearF;

        public DateFormatterV1(int day, int month, int year)
        {
            DayF = day;
            MonthF = month;
            YearF = year;
        }

        //Date date = new(04, 18, 2008);
        public void GetDate()
        {
            DayF = input.GetDay();
            MonthF = input.GetMonth();
            YearF = input.GetYear();
        }

        Date date = new Date(DayF, MonthF, YearF); 

        public void FormatCH()
        {
            Console.WriteLine($"CH: {DayF}.{MonthF}.{YearF}");
        }
        public void FormatUS()
        {
            Console.WriteLine($"US: {MonthF}/{DayF}/{YearF}");
        }
        public void FormatISO()
        {
            Console.WriteLine($"ISO: {YearF}-{MonthF}-{DayF}");
        }
    }
}
