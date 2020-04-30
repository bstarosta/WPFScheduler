using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler.Database
{
    /// <summary>
    /// Klasa modelująca zadanie do wykonania. Zawiera nazwę zadania, jego typ
    /// oraz termin, do którego dane zadanie musi zostać wykonane.
    /// </summary>
    public class TaskToDo
    {
        /// <summary>
        /// Konstruktor bezparametryczny
        /// </summary>
        public TaskToDo()
        {
        }

        /// <summary>
        /// Konstruktor tworzący obiekty na podstawie danych podanych jako argumenty
        /// </summary>
        /// <param name="name">Nazwa zadania</param>
        /// <param name="type">Typ zadania</param>
        /// <param name="deadline">Termin wykonania zadania</param>
        public TaskToDo(string name, string type, DateTime deadline)
        {
            Name = name;
            Deadline = deadline;
            Type = type;
        }

        /// <value>Identyfikator zadania generowany przez bazę danych</value>
        public int TaskToDoID { get; set; }

        /// <value>Nazwa zadania</value>
        public string Name { get; set; }

        /// <value>Termin</value>
        public DateTime Deadline { get; set; }

        /// <value>Typ zadania</value>
        public string Type { get; set; }
    }
}
