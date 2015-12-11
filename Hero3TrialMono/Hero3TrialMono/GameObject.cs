using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Exeptions;

    public abstract class GameObject
  {
      Position position;

      protected GameObject(Position position)
      {
          this.Position = position;
      }

      public Position Position {
          get { return this.position; }
          set
          {
              if (value.X < 0 || value.Y < 0)
              {
                  throw  new ObjectOutOfBounds("The specified object is out of the map");
              }
              this.position = value;
          }
        }
  }
}
