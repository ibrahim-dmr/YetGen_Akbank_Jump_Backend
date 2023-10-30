using EncapsulationExcercise.Entities;

Console.WriteLine("Encapsulation");

Account account1 = new("İbrahim", "Demir");
//account1.Withdraw(2000);
//account1.Withdraw(200);
//account1.Withdraw(200);
account1.Balance -= 1000;
account1.Balance -= 500;
account1.Balance -= 450;


Console.WriteLine($"Balance: {account1.Balance}");