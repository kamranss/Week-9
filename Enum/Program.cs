// See https://aka.ms/new-console-template for more information

using Enum.Service;

User user1 = new User();

user1.Name = "Kamran";
user1.Surname = "Suleyman";
Console.WriteLine(user1.Id);

User user2 = new User();

user2.Name = "Arif";
user2.Surname = "Aliyev";
user2.Position = Positions.ProcurementSpecialist;
Console.WriteLine(user2.Id);


