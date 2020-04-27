using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler.Database
{
    public static class ApplicationDatabaseData
    {
        public static List<Event> Events { get; set; }
        public static List<TaskToDo> TasksToDo { get; set; }

        public static void LoadDataFromDatabase()
        {
            using(var context =new SchedulerDbContext())
            {
                Events = context.Events.ToList();
                TasksToDo = context.TasksToDo.ToList();
            }
        }
    }
}
