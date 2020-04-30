using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler.Database
{
    /// <summary>
    /// Klasa przechowująca lokalne dane aplikacji
    /// </summary>
    public static class ApplicationDatabaseData
    {
        ///<value>Obiekt zarządzający danymi o wydarzeniach</value>
        public static EventsData EventsAppData { get; private set; }

        ///<value>Obiekt zarządzający danymi o zadaniach do wykonania</value>
        public static TasksToDoData TasksToDoAppData { get; private set; }


        /// <summary>
        /// Metoda dane aplikacji. Tworzy nową bazę danych, jeżeli taka jeszcze nie istnieje
        /// i pobiera dane z bazy do aplikacji
        /// </summary>
        public static void InitializeData()
        {
            using (var context = new SchedulerDbContext())
                context.Database.CreateIfNotExists();
            EventsAppData = new EventsData();
            TasksToDoAppData = new TasksToDoData();
            EventsAppData.LoadDataFromDatabase();
            TasksToDoAppData.LoadDataFromDatabase();
        }
    }
}
