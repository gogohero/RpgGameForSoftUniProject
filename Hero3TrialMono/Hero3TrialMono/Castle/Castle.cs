using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle
{
    using Interfaces;
    public abstract class Castle : GameObject, ICastle
    {
        private string name;


        public Castle(Vector2 position) 
            : base(position)
        {

        }

        public void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
