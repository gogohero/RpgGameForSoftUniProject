using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Characters
{
    public class Warrior : Champion
    {
        public Warrior(Position position, int damage, string name) 
            : base(position, damage, name)
        {
        }
    }
}
