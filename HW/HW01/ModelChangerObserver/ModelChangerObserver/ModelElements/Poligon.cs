using ModelChangerObserver.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelChangerObserver.ModelElements
{
  internal class Poligon
  {
    public List<Point3D> points;

    public Poligon()
    {
      this.points = new List<Point3D>();
      points.Add(new Point3D());
    }
  }
}
