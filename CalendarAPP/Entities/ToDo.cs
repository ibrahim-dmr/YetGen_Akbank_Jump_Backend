using CalendarAPP.Abstract;
using CalendarAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPP.Entities
{
    public class ToDo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this ToDo: {Title}");
        }
    }
}
