using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Characters
{
   public class Archer : Champion
    {
      
       public Archer(Vector2 position, int damage, string name) 
            : base(position, damage, name)
       {
           Image = "archer";
           
       }
    }
}
