using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Interfaces;
using Hero3TrialMono.Items;

namespace Hero3TrialMono.Engine
{
     public class Engine 
     {

         private List<ICharacter> characters;
         private List<Item> items;

         public Engine()
         {
             characters = new List<ICharacter>();
             items = new List<Item>();
         }

         public bool IsRuning { get; private set; }

         public void Run()
         {
             
         }
     }
}
