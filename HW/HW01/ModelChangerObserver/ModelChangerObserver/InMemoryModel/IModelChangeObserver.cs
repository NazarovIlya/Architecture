using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelChangerObserver.InMemoryModel
{
  internal interface IModelChangerObserver
  {
    public void ApplyUpdateModel();
  }
}
