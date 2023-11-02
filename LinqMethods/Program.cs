using LinqMethods.Entities;

Console.WriteLine("Linq Methods!");

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
