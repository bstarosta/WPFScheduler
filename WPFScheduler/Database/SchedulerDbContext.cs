using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFScheduler.Database;

namespace WPFScheduler
{
    public class SchedulerDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<TaskToDo> TasksToDo { get; set; }
    }
}
