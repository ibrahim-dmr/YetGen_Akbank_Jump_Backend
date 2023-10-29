using OOP_Excercise.Entities;
using OOP_Excercise.Entities.ComputerComponents;
using OOP_Excercise.Enums;

Console.WriteLine();

Storage storage1 = new Storage("WD Blue", 1, CapacitySizeType.TB);
CPU cPU1 = new CPU(CPUBrandType.Intel, "i7", 2.4, CPUClockSpeedType.GHz, 16, CPUCacheType.M);

Computer computer1 = new Computer("Apple", "Macbook", cPU1, "Corsair 16 GB", storage1);

Console.WriteLine($"Brand: {computer1.Brand} Model: {computer1.Model} CPU: {computer1.CPU.BrandType}{computer1.CPU.Model} {computer1.CPU.ClockSpeed}{computer1.CPU.ClockSpeedType} {computer1.CPU.CacheSize}{computer1.CPU.CacheType}");
