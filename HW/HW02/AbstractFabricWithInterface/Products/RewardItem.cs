using AbstractFabricWithInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricWithInterface.Products
{
  public abstract class RewardItem : IGameItem
  {
    public void Open()
    {
      Console.WriteLine($"Вы получили в награду {GetType().Name}");
    }
  }
}
