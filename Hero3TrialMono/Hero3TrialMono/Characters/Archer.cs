using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Characters
{
   public class Archer : Player
    {
       public Archer(Position position, int damage, string name, int gold, int crystals, int mercury, int sulfur, int wood, int rock, int jems) 
            : base(position, damage, name, gold, crystals, mercury, sulfur, wood, rock, jems)
       {
       }
    }
}
