using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle
{
    using Interfaces;
    public abstract class Castle : GameObject, ICastle
    {
        private string name;


        public Castle(Position position) 
            : base(position)
        {

        }

        public void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
