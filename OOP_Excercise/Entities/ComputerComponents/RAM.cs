using OOP_Excercise.Enums;
using OOP_Excercise.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise.Entities.ComputerComponents
{
    public class RAM
    {
        public string Brand { get; set; }  //Corsair
        public Capacity Capacity { get; set; }


        public RAM()
        {

        }

        public RAM(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }
    }
}
