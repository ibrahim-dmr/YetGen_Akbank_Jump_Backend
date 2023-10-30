using CalendarAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPP.Entities
{
    public class ToDo : Event
    {
        public string Importance { get; set; }


        public ToDo()
        {
        }
        public ToDo(string ımportance)
        {
            Importance = ımportance;
        }
    }
}
