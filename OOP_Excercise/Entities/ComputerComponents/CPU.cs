using OOP_Excercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise.Entities.ComputerComponents
{
    public class CPU
    {
       

        public CPUBrandType BrandType { get; set; }
        public string Model { get; set; }
        public double ClockSpeed { get; set; }
        public CPUClockSpeedType ClockSpeedType { get; set; }
        public int CacheSize { get; set; }
        public CPUCacheType CacheType { get; set; }

        public CPU()
        {
            
        }

        public CPU(CPUBrandType brandType, string model, double clockSpeed, CPUClockSpeedType clockSpeedType, int cacheSize, CPUCacheType cPUCacheType)
        {
            BrandType = brandType;
            Model = model;
            ClockSpeed = clockSpeed;
            ClockSpeedType = clockSpeedType;
            CacheSize = cacheSize;
            CacheType = cPUCacheType;
        }
    }
}
