using Programmieraufgaben;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datumsformatierung
{
    internal class Input
    {
        //public static int GetDate()
        //{
        //    int DayF = GetDay();
        //    int MonthF = GetMonth();
        //    int YearF = GetYear();
        //    Date date = new Date(DayF, MonthF, YearF);
        //    return date(DayF, MonthF, YearF);
        //}
        public string GetFormat()
        {
            string format = Console.ReadLine();
            return format;
        }
        public int GetDay()
        {
            Console.WriteLine("Enter a Day:");
            int day = Int32.Parse(Console.ReadLine());
            return day;
        }
        public int GetMonth()
        {
            Console.WriteLine("Enter a Month:");
            int month = Int32.Parse(Console.ReadLine());
            return month;
        }
        public int GetYear()
        {
            Console.WriteLine("Enter a Year:");
            int year = Int32.Parse(Console.ReadLine());
            return year;
        }
    }
}
