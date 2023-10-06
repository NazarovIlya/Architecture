using SRP;

Console.WriteLine("SOLID");
Console.WriteLine($"\n{string.Join("", Enumerable.Repeat("=", 50))}\n");

Employee employee =  new(name: "Yana", 2023);
Console.WriteLine(employee);