using ModelChangerObserver.ModelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelChangerObserver.InMemoryModel
{
  internal class ModelStore : IModelChanger
  {
    public List<PoligonalModel> models;
    public List<Scene> scenes;
    public List<Flash> flashes;
    public List<Camera> cameras;
    private IModelChangerObserver[] changerObserver;

    public ModelStore(IModelChangerObserver[] changerObserver)
    {
      this.changerObserver = changerObserver;
      models = new List<PoligonalModel>();
      scenes = new List<Scene>();
      flashes = new List<Flash>();
      cameras = new List<Camera>();

      models.Add(new PoligonalModel(
        new List<Texture> { new Texture() }));
      flashes.Add(new Flash());
      cameras.Add(new Camera());
      scenes.Add(new Scene(0, models, flashes, cameras));
    }

    public Scene? GetScena(int id)
    {
      for (int i = 0; i < scenes.Count; i++)
      {
        if (scenes[i].id == id)
        {
          return scenes[id];  
        }
      }
      return null;
    }

    public void NotifyChange(IModelChanger sender)
    {
      throw new NotImplementedException();
    }
  }
}
