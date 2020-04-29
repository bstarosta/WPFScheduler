using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler.Database
{
    /// <summary>
    /// Klasa przechowująca lokalną kopię danych z bazy połączonej z aplikacją
    /// </summary>
    public static class ApplicationDatabaseData
    {
        /// <value>Lista przechowująca lokalne danych o wydarzeniach</value>
        public static List<Event> Events { get; set; }

        /// <value>Lista przechowująca lokalne danych o zadaniach do wykonania</value>
        public static List<TaskToDo> TasksToDo { get; set; }

        /// <summary>
        /// Metoda ładująca dane z bazy do aplikacji
        /// </summary>
        public static void LoadDataFromDatabase()
        {
            using(var context =new SchedulerDbContext())
            {
                Events = context.Events.ToList();
                TasksToDo = context.TasksToDo.ToList();
            }
        }

        /// <summary>
        /// Metoda tworząca nową baze danych współpracującą z aplikacją, jeżeli taka
        /// jeszcze nie istnieje
        /// </summary>
        public static void InitializeDatabase()
        {
            using (var context = new SchedulerDbContext())
                context.Database.CreateIfNotExists();
        }
    }
}
