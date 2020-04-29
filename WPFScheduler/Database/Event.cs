using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler
{
    /// <summary>
    /// Klasa modelująca wydarzenie do zarejestrowania w kalendarzu. Zawiera nazwę wydarzenia,
    /// jego typ, informację o ramach czasowych oraz opis. 
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Konstruktor bezparametryczny
        /// </summary>
        public Event() { }

        /// <summary>
        /// Konstruktor tworzący obiekty na podstawie danych podanych jako argumenty
        /// </summary>
        /// <param name="start">Czas startu wydarzenia</param>
        /// <param name="end">Czas zakończenia wydarzenia</param>
        /// <param name="name">Nazwa wydarzenia</param>
        /// <param name="type">Typ wydarzenia</param>
        /// <param name="description">Opis wydarzenia</param>
        public Event(DateTime start, DateTime end, string name, string type, string description)
        {
            Start = start;
            End = end;
            Name = name;
            Type = type;
            Description = description;
        }

        /// <value>Identyfikator wydarzenia generowany przez bazę danych</value>
        public int EventID { get; set; }

        /// <value>Czas startu wydarzenia</value>
        public DateTime Start { get; set; }

        /// <value>Czas zakończenia wydarzenia</value>
        public DateTime End { get; set; }

        /// <value>Nazwa wydarzenia</value>
        public string Name { get; set; }

        /// <value>Typ wydarzenia</value>
        public string Type { get; set; }

        /// <value>Opis wydarzenia</value>
        public string Description { get; set; }
    }
}
