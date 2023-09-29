using ModelChangerObserver.InMemoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelChangerObserver.ModelElements
{
  internal class PoligonalModel
  {
    public List<Poligon> poligons;
    public List<Texture> textures;

    public PoligonalModel(List<Texture> textures)
    {
      this.textures = textures;
      this.poligons = new List<Poligon>
      {
        new Poligon()
      };
    }
  }
}
