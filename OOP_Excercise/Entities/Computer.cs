using OOP_Excercise.Entities.ComputerComponents;
using OOP_Excercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CPU CPU { get; set; }
        public RAM RAM { get; set; }
        public Storage Storage { get; set; }


        public Computer()
        {
            Random random = new Random();
            Id = random.Next(10000, int.MaxValue);
        }

        public Computer(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;

        }


        public Computer(string brand, string model, CPU cPU, RAM rAM, Storage storage) : this(brand, model)
        {
            CPU = cPU;
            RAM = rAM;
            Storage = storage;

        }


    }
}

