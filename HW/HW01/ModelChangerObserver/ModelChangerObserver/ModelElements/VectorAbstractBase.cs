using ModelChangerObserver.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelChangerObserver.ModelElements
{
  internal abstract class VectorAbstractBase
  {
    public Point3D location;
    public Angle3D angle;

    public virtual void Rotate(Angle3D angle) { }
    public virtual void Move(Point3D point) { }
  }
}
