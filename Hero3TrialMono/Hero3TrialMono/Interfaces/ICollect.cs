using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Items;

namespace Hero3TrialMono.Interfaces
{
   public interface ICollect
    {
        IEnumerable<Item> suplys { get; }
        void addToSuplies(Item suply, int count);



    }
}
