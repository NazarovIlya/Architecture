using AbstractFabricWithInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricWithInterface.Factories
{
  internal class DiamonFactory : ItemFactory
  {
    public override IGameItem CreateItem()
    {
      return new Diamond();
    }
  }
}
