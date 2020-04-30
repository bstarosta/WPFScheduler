using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFScheduler.Database;

namespace WPFScheduler.Database
{
    /// <summary>
    /// Klasa umożliwiająca korzystanie z połączonej z aplikacją bazy danych
    /// </summary>
    public class SchedulerDbContext : DbContext
    {
        ///<value>Reprezentuje tabelę "Events" w bazie danych</value>
        public DbSet<Event> Events { get; set; }

        ///<value>Reprezentuje tabelę "TasksToDo" w bazie danych</value>
        public DbSet<TaskToDo> TasksToDo { get; set; }
    }
}
