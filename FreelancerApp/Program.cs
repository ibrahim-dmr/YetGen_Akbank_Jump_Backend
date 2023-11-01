using FreelancerApp.Abstract;
using FreelancerApp.Common;
using FreelancerApp.Entities;
using FreelancerApp.Service;


#region Input
//Console.Write("Name: ");
//string name = Console.ReadLine();

//Console.Write("Surname: ");
//string surname = Console.ReadLine();

//Console.Write("Phone number: ");
//string phoneNumber = Console.ReadLine();
#endregion

//Customer customer1 = new()
//{
//    Id = Guid.NewGuid(),
//    CreatedOn = DateTimeOffset.Now,
//    FirstName = name,
//    LastName = surname,
//    PhoneNumber = phoneNumber
//};

ICsvConvertible freelancerInstance = new Freelancer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "John",
    LastName = "Doe",
    WorkExperience = "5 years of experince in web development",
    Reviews = new List<Review>
    {
        new Review{Text = "Excellent freelancer!", Rating = 5 },
        new Review{Text = "Great Work!", Rating = 4 }
    }
};


//Console.WriteLine(customer1.GetValuesCSV());
Console.WriteLine(freelancerInstance.GetType().ToString().Split(".").LastOrDefault());

NotepadService notepadService = new();
notepadService.SaveToNotepad(freelancerInstance);


string customerData = notepadService.GetOnNotepad($"{FileLocation.ProjectFolder}\\Database\\Customers.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}