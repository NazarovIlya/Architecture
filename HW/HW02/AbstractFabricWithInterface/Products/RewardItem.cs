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
      Console.WriteLine($"You have received a reward {GetType().Name.ToUpper()} award!");
    }
  }
}
