using ProductShipping.Entities;
using ProductShipping.Services;

Console.WriteLine("Product Shipping!");

Product product1 = new Product("Laptop", 2.5M, 1200M);
Product product2 = new Product("Smartphone", 0.3M, 800M);
Product product3 = new Product("Headphones", 0.1M, 100M);
Product product4 = new Product("Tablet", 1.0M, 400M);


string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Database\\CountryInfos.txt";

NotepadService notepadService = new();
string[] lines = notepadService.ReadFromNotepad(path).Split("\r\n");
List<CountryInformation> countryInformations = new();

foreach(var line in lines)
{
    CountryInformation countryInformation= new(line);
    countryInformations.Add(countryInformation);
}


ShippingService shippingService = new();

foreach(var countryInfo in countryInformations)
{
    Console.WriteLine(shippingService.CalculateTax(product4, countryInfo)); 
}

Console.WriteLine();