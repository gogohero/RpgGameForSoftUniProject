using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Items
{
    using Interfaces;
    public abstract class Item : GameObject, IItem
    {
        private int itemCount;

        protected Item(Vector2 position, int itemCount) 
            :base(position)
        {
            this.ItemCount = itemCount;
            this.ItemState = ItemState.Available;
        }

      
        public int ItemCount
        {
            get { return this.itemCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Resource cannot be engative");
                }
                value = this.itemCount;
            }
        }

        public ItemState ItemState { get; set; }
    }
}
