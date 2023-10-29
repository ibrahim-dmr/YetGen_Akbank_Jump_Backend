using OOP_Excercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise.Entities.ComputerComponents
{
    public class Storage
    {

        public string Brand { get; set; }
        public int Size { get; set; }
        public CapacitySizeType SizeType { get; set; }

        public Storage()
        { 

        }

        public Storage(string brand, int size, CapacitySizeType sizeType)
        {
            Brand = brand;
            Size = size;
            SizeType = sizeType;
        }

    }
}
