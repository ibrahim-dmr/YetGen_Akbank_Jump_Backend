using CalendarAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPP.Entities
{
    public class Meeting : Event
    { 
        public List<string> Guests { get; set; }


        public Meeting()
        {
        }
        public Meeting(List<string> guests)
        {
            Guests = guests;
        }
    }
}
