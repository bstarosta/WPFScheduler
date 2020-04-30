using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler.Database
{
    /// <summary>
    /// Klasa zarządzająca danymi o wydarzeniach. Zawiera metody pozwalające
    /// na zapisywanie i ususuwania danych o wydarzeniach.
    /// </summary>
    public class EventsData
    {
        /// <value>Lista przechowująca lokalne dane o wydarzeniach</value>
        public List<Event> Events { get; set; }

        /// <summary>
        /// Metoda ładująca dane o wydarzeniach z bazy do aplikacji
        /// </summary>
        public void LoadDataFromDatabase()
        {
            using (var context = new SchedulerDbContext())
                Events = context.Events.ToList();
        }

        /// <summary>
        /// Metoda zapisująca dane o wydarzeniu do bazy danych oraz danych lokalnych
        /// </summary>
        /// <param name="ev">Wydarzenie do zapisania</param>
        public void Save(Event ev)
        {
            using (var context = new SchedulerDbContext())
            {
                context.Events.Add(ev);
                context.SaveChanges();
            }
            Events.Add(ev);
        }

        /// <summary>
        /// Metoda usuwająca dane do wydarzeniu z bazy danych i danych lokalnych aplikacji
        /// </summary>
        /// <param name="ev">Wydarzenie do usunięcia</param>
        public void Remove(Event ev)
        {
            Events.Remove(ev);
            using (var context = new SchedulerDbContext())
            {
                context.Events.Attach(ev);
                context.Events.Remove(ev);
                context.SaveChanges();
            }
        }
    }
}
