using AbstractFabricWithInterface.Interfaces;
using AbstractFabricWithInterface.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricWithInterface.Factories
{
  internal class SilverFactory : ItemFactory
  {
    public override IGameItem CreateItem()
    {
      return new Silver();
    }
  }
}
