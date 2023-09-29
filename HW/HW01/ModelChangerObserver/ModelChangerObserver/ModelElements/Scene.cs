using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelChangerObserver.ModelElements
{
  internal class Scene
  {
    public int id;
    public List<PoligonalModel> models;
    public List<Flash> flashes;
    public List<Camera> cameras;

    public Scene(int id, List<PoligonalModel> models, List<Flash> flashes, List<Camera> cameras)
    {
      this.id = id;
      this.models = models;
      if (models.Count > 1)
      {
        this.models = models;
      }
      else
      {
        throw new ArgumentNullException(nameof(models));
      }      
      this.flashes = flashes;
      if (cameras.Count > 1)
      {
        this.cameras = cameras;
      }
      else
      {
        throw new ArgumentNullException(nameof(cameras));
      }
    }
    public T method<T>(T model)
    {
      return model;
    }

    public K method<T, K>(T model, K camera)
    {
      return camera;
    }
  }
}
