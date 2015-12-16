using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono
{
    using Exeptions;

    public abstract class GameObject
    {
      
      private static string image; 
      private Rectangle rectangle;
        private Vector2 position; 

      protected GameObject(Vector2 position)
      {
          this.Position = position;
      }


        public Vector2 Position { get; set; }
      public  string Image
      {
          get { return image; }
          set { image = value; }
      }

      public Rectangle Rectangle
      {
          get { return rectangle; } 
          set { rectangle = value; }
      }
  }
}
