
int[] numberArray = { 1, 2, 3, 4, 4, 4, 5, 5, 7, 7 };
int maxNumberOfArray = numberArray.Max();
int uniqueMembersCount = numberArray.Distinct().Count();

int secondNumberOfArray = numberArray.ReturnSecondNumberOfArray();

string rawName = "İbrahim-Halil_Demir";
rawName.GetLastName();


Console.WriteLine();

static class MyExtensions
{
    public static string GetLastName(this string fullname)
    {
        return fullname.Split('_')[1];
    }
    public static int ReturnSecondNumberOfArray(this int[] array)
    {
        if (array.Length >= 2)
            return array[1];
        throw new Exception("Array Must Longer Then One Element");
    }
}