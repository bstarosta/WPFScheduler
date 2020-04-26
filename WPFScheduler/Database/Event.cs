using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler
{
    public class Event
    {
        public Event() { }

        public Event(DateTime start, DateTime end, string name, string type, string description)
        {
            Start = start;
            End = end;
            Name = name;
            Type = type;
            Description = description;
        }

        public int EventID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
