// See https://aka.ms/new-console-template for more information
using AbstractFabricWithInterface;
using AbstractFabricWithInterface.Products;

Console.WriteLine("Hello, World!");

RewardItem gold = new Gold();
RewardItem silver = new Silver();
RewardItem diamond = new Diamond();
RewardItem sapphire = new Supphire();
RewardItem platinum = new Platinum();

gold.Open();
silver.Open();
diamond.Open();
sapphire.Open();
platinum.Open();
