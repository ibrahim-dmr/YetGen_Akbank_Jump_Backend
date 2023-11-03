using LinqMethodsExcercises.Entities;
using System.Collections.Concurrent;

Console.WriteLine("Linq Methods: Average, Concat, Distinct, Skip, Take");

#region Average

List<Product> products = new List<Product>()
    {
        new Product("Laptop", 1000.50m),
        new Product("Smartphone", 500.75m),
        new Product("Tablet", 300.25m),
        new Product("Headphones", 50.20m),
        new Product("Camera", 750.90m)
    };

decimal averagePrice = products.Average(x => x.Price);
Console.WriteLine($"Average Price: {averagePrice}");
#endregion

#region Concat

List<Person> firstCollection = new List<Person>
        {
            new Person("John", "Doe"),
            new Person("Alice", "Smith")
        };

List<Person> secondCollection = new List<Person>
        {
            new Person("Bob", "Johnson"),
            new Person("Emily", "Wilson")
        };

IEnumerable<Person> concatenatedCollection = firstCollection.Concat(secondCollection);
Console.WriteLine("\nConcatenated Collection:");

foreach (var person in concatenatedCollection)
{
    Console.WriteLine($"{person.FirstName} {person.Lastname}");
}
#endregion

#region Distinct

List<Product> productsDistinct = new List<Product>
        {
            new Product("Laptop", 1000.0m),
            new Product("Phone", 500.0m),
            new Product("Tablet", 700.0m),
            new Product("Laptop", 1000.0m), // Bu aynı ürünü temsil eder
            new Product("Headphones", 200.0m),
            new Product("Tablet", 700.0m), // Bu aynı ürünü temsil eder
        };

// Distinct metodu kullanarak ürünleri benzersiz şekilde filtrele
IEnumerable<Product> distinctProducts = products.Distinct(new ProductEqualityComparer());

Console.WriteLine("\nDistinct Products:");

foreach (var product in distinctProducts)
{
    Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price:C}");
}


#endregion

#region Skip

List<string> cities = new List<string>
        {
            "New York",
            "Los Angeles",
            "Chicago",
            "Houston",
            "Miami",
            "San Francisco"
        };

int skipCount = 2;
IEnumerable<string> remainingCities = cities.Skip(skipCount);
Console.WriteLine($"\nRemaining Cities after skipping {skipCount} elements" );

foreach (var city in remainingCities)
{
    Console.WriteLine(city);
}

#endregion

#region Take
List<Fruit> fruits = new List<Fruit>
        {
            new Fruit("Apple"),
            new Fruit("Banana"),
            new Fruit("Cherry"),
            new Fruit("Grapes"),
            new Fruit("Mango"),
            new Fruit("Orange"),
            new Fruit("Strawberry")
        };

int takeCount = 3; // İlk üç meyveyi alacağız
IEnumerable<Fruit> selectedFruits = fruits.Take(takeCount);

Console.WriteLine($"\nSelected fruits (first {takeCount} elements): ");

foreach (var fruit  in selectedFruits)
{
    Console.WriteLine(fruit.Name);
}
#endregion