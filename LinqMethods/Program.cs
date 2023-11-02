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

Console.WriteLine(AllItemsGreater);
