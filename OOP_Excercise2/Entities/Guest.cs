using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise2.Entities
{
    public class Guest
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }

        public Guest(string name, string surname, string ıdNumber, string phoneNumber)
        {
            Random random = new Random();
            Id = random.Next(1000, int.MaxValue);
            Name = name;
            Surname = surname;
            IdNumber = ıdNumber;
            PhoneNumber = phoneNumber;
        }
    }
}
