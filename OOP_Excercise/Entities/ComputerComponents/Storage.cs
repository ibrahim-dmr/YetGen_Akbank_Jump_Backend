﻿using OOP_Excercise.Enums;
using OOP_Excercise.ValueObjects;
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

        public Capacity Capacity { get; set; }
        public Storage()
        { 

        }

        public Storage(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
            
        }

    }
}
