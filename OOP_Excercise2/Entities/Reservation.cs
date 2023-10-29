using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise2.Entities
{
    public class Reservation
    {

        public int Id { get; set; }

        //Reservation class'ının içerinde bir Guest entity'si tutmuş oluyorum
        public Guest Guest { get; set; } 
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Reservation(Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            Random random = new Random();
            Id = random.Next(1000, int.MaxValue);
            Guest = guest;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}
