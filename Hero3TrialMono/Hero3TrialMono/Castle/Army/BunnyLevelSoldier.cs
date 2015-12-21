using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Army
{
    public class BunnyLevelSoldier : Soldier
    {
        public BunnyLevelSoldier(Vector2 position, string name, int soldierCount, int damage, int health, int defence, int speed) 
            : base(position, name, soldierCount, damage, health, defence, speed)
        {

        }
    }
}
