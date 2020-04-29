using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler
{
    /// <summary>
    /// Klasa zawierająca metody przydatne przy obsłudze obiektów typu <c>DateTime</c>
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// Metoda umożliwiająca dodanie do podanej daty czasu dnia w postaci
        /// godzin i minut zapisanych w formie tekstowej. Pomocna przy parsowaniu danych
        /// wprowadzonych przez użytkownika do pól tekstowych, ponieważ użyta
        /// tutaj metoda <c>Convert.ToDateTime</c> automatycznie załawia sprawę sprawdzenia formatu i zakresu
        /// podanych danych.
        /// </summary>
        /// <param name="date">Data do której ma zostać dodany czas dnia</param>
        /// <param name="hours">Godzina</param>
        /// <param name="minutes">Minuty</param>
        /// <returns></returns>
        public static DateTime addTimeToDate(DateTime date, string hours, string minutes)
        {
            CultureInfo culture = new CultureInfo("pl-PL");
            string dateString = $"{date:yyyy/MM/dd} {hours}:{minutes}";
            return Convert.ToDateTime(dateString, culture);
        }
    }
}
