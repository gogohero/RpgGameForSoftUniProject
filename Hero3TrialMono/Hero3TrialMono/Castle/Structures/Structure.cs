using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Castle.Structures
{
    using Interfaces;

    public abstract class Structure : GameObject , IStructure
    {
        public Structure(Position position, string name) 
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
