using LinqMethods.Entities;
using LinqMethods.Enums;

Console.WriteLine("Linq Methods!");

#region All
List<int> numbers = new() { 100, 45, 140, 150, 250 };

bool AllItemsGreater = numbers.All(x => x > 50);

//bool allItemsGreater = true;

//foreach (int number in numbers)
//{
//    if (number <= 50)
//    {
//        allItemsGreater = false;
//        break;
//    }
//}
Console.WriteLine("\nExample All Method:");
Console.WriteLine($"{AllItemsGreater} \n");
#endregion

#region Any
List<User> userList = new List<User> 
{
    new User("TravelExplorer_", 100),
    new User("FoodieAdventures", 10),
    new User("FitnessFreak101", 170),
    new User("ArtisticSoul_", 300),
    new User("FashionistaStyle", 1800)
};

Console.WriteLine("Example Any Method:");
Console.WriteLine(userList.Any(x => x.FollowerCount >= 1000 && x.UserName.Contains("Style")));
#endregion

#region Where
Console.WriteLine($"\nExample Where Method:");
List<Person> people = new List<Person>
{
    new Person(firstName: "John", lastName: "Doe", age: 30, Gender.Male),
    new Person(firstName: "Alice", lastName: "Smith", age: 25, Gender.Female),
    new Person(firstName: "Bob", lastName: "Johnson", age: 35, Gender.Male),
    new Person(firstName: "Emily", lastName: "Wilson", age: 28, Gender.Female),
    new Person(firstName: "Michael", lastName: "Brown", age: 40, Gender.Male),
    new Person(firstName: "Olivia", lastName: "Jones", age: 22, Gender.Female),
    new Person(firstName: "David", lastName: "Lee", age: 32, Gender.Male),
    new Person(firstName: "Sophia", lastName: "Davis", age: 29, Gender.Female),
    new Person(firstName: "William", lastName: "Anderson", age: 37, Gender.Female),
    new Person(firstName: "Ava", lastName: "Clark", age: 26, Gender.Female)
};

List<Person> filterResult = people.Where(x => x.Age < 25  && x.Gender == Gender.Female).ToList();

foreach (var item in filterResult)
{ 
    Console.WriteLine(item.FirstName);
}
#endregion

#region FirstOrDefault
Console.WriteLine("\nFirs Or Default: ");
List<Book> books = new List<Book>
{
    new Book("Don Quixote", "Miguel de Cervantes", "9780199537916", new DateTime(1605, 1, 16), Genre.ClassicFiction),
    new Book("War and Peace", "Leo Tolstoy", "9780199232765", new DateTime(1869, 1, 1), Genre.HistoricalNovel),
    new Book("Pride and Prejudice", "Jane Austen", "9780141439518", new DateTime(1813, 1, 28), Genre.RomanticFiction),
    new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", new DateTime(1925, 4, 10), Genre.ClassicFiction),
    new Book("Moby-Dick", "Herman Melville", "9781503280783", new DateTime(1851, 10, 18), Genre.Adventure),
    new Book("Crime and Punishment", "Fyodor Dostoevsky", "9780679734500", new DateTime(1866, 11, 11), Genre.PsychologicalFiction)
};


var book = books.Where(x => x.Genre == Genre.RomanticFiction).FirstOrDefault();

Console.WriteLine();
#endregion

#region Single SingleOrDefault

var book1 = books.Where(x => x.ISBN == "9780199232765").SingleOrDefault();
// Iterable'da tek eleman varsa onu döndürür. Eleman yoksa veya birden fazla eleman varsa hata verir
// Eleman yoksa hata vermesin isterse Default değeri döndürür.

Console.WriteLine();

#endregion
