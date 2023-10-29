using OOP_Excercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise.ValueObjects
{
    public class Capacity
    {

        public int Size { get; set; }  
        public CapacitySizeType SizeType { get; set; } 

        public Capacity(int size, CapacitySizeType sizeType)
        {
            Size = size;
            SizeType = sizeType;
        }
    }
}
