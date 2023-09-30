// See https://aka.ms/new-console-template for more information
using AbstractFabricWithInterface.Products;

Console.WriteLine("Hello, World!");

RewardItem gold = new Gold();
RewardItem silver = new Silver();

gold.Open();
silver.Open();
