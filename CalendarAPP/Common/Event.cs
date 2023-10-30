using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPP.Common
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<string> Details { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        public Event()
        {
            Id = Guid.NewGuid();
        }

        public Event(string title, List<string> details, DateTime startTime, DateTime endTime)
        {
            Title = title;
            Details = details;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
