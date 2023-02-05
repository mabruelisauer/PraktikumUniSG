using Programmieraufgaben;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datumsformatierung
{
    internal class DateformatterV3
    {
        public string GetFormat(Date date, string isoCode)
        {
            if (isoCode == "US")
            {
                string formatUS = $"US: {date.Month}/{date.Day}/{date.Year}";
                return formatUS;
            }
            else if (isoCode == "CH")
            {
                string formatCH = $"CH: {date.Day}.{date.Month}.{date.Year}";
                return formatCH;
            }
            else if (isoCode == "ISO")
            {
                string formatISO = $"ISO: {date.Year}-{date.Month}-{date.Day}";
                return formatISO;
            }
            return "";
        }

    }
}
