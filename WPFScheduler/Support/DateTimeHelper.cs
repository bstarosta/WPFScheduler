using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler
{
    public static class DateTimeHelper
    {
        public static DateTime addTimeToDate(DateTime date, string hours, string minutes)
        {
            CultureInfo culture = new CultureInfo("pl-PL");
            string dateString = $"{date:yyyy/MM/dd} {hours}:{minutes}";
            return Convert.ToDateTime(dateString, culture);
        }
    }
}
