using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle.Army
{
   public class CaptainLevelSoldier : Soldier
    {
        public CaptainLevelSoldier(Position position, string name, int soldierCount, int damage, int health, int defence, int speed) 
            : base(position, name, soldierCount, damage, health, defence, speed)
        {
        }
    }
}
