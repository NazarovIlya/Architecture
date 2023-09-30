using AbstractFabricWithInterface;
using AbstractFabricWithInterface.Factories;
using AbstractFabricWithInterface.Products;


RewardItem gold = new Gold(); // получение золота
RewardItem silver = new Silver(); // получение серебра
RewardItem diamond = new Diamond(); // получение алмазов
RewardItem sapphire = new Supphire(); // получение сапфиров
RewardItem platinum = new Platinum(); // получение платины
RewardItem pearl = new Pearl(); // получение жемчуга
RewardItem amber = new Amber(); // получение янтаря

// у каждой награды вызываем метод поздрвления
gold.Open();
silver.Open();
diamond.Open();
sapphire.Open();
platinum.Open();
pearl.Open();
amber.Open();

// подводим черту и начинаем нормальную работу
Console.WriteLine($"\n\n{string.Join("", Enumerable.Repeat("*=*", 30))}\n");

// создаём список фабрик в упрощенном стиле
List<ItemFactory> factories = new List<ItemFactory>()
{
  new AmberFactory(),
  new AmberFactory(),
  new GoldFactory(),
  new GoldFactory(),
  new GoldFactory(),
  new GoldFactory(),
  new GoldFactory(),
  new PlatinumFactory(),
  new PlatinumFactory(),
  new PlatinumFactory(),
  new PlatinumFactory(),
  new PlatinumFactory(),
  new PearlFactory(),
  new SilverFactory(),
  new SilverFactory(),
  new SupphireFactory(),
  new SupphireFactory(),
  new DiamonFactory(),
  new DiamonFactory(),
  new DiamonFactory(),
  new DiamonFactory(),
  new DiamonFactory(),
};

Random random = new Random();

// Выводим награды в случайном порядке
foreach (var factory in factories)
{
  int index = random.Next(0, factories.Count());
  factories[index].OpenReward();
}