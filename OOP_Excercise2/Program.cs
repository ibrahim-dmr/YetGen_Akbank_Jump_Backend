using OOP_Excercise2.Entities;


//Guest'ten ve Reservation'dan instance'lar üretelim
Guest guest1 = new("Yeliz", "Akın", "1114225653", "0532222222");
Reservation reservation1 = new(guest1, new DateTime(2023, 06, 06, 14, 0, 0), new DateTime(2023, 07, 08));

Console.WriteLine($"Name: {reservation1.Guest.Name} \nCheckIn Date: {reservation1.CheckInDate} \nCheckOut Date: {reservation1.CheckOutDate}");