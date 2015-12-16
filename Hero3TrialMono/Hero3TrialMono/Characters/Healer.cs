using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Characters
{
   public class Healer : Champion
    {
       public Healer(Vector2 position, int damage, string name) : base(position, damage, name)
       {
           Image = "healer";
       }
    }
}
