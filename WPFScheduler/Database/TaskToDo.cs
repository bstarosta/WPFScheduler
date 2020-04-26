using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler.Database
{
    public class TaskToDo
    {
        public TaskToDo()
        {
        }

        public TaskToDo(string name, string type, DateTime deadline)
        {
            Name = name;
            Deadline = deadline;
            Type = type;
        }

        public int TaskToDoID { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Type { get; set; }
    }
}
