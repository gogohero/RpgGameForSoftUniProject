using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Structures
{
    using Interfaces;

    public abstract class Structure : GameObject , IStructure
    {
        public Structure(Vector2 position, string name) 
            : base(position)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Buy()
       {
           
       }

       
    }
}
