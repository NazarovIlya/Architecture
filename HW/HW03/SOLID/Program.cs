using SRP;

Console.WriteLine("SOLID");
Console.WriteLine($"\n{string.Join("", Enumerable.Repeat("=", 50))}\n");
Employee employee =  new(name: "Yana", year: 2023, month: 10, day: 6);
Console.WriteLine(employee);