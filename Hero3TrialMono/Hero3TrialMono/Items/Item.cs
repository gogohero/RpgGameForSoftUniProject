using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono.Items
{
    public abstract class Item : GameObject
    {
        private int itemCount;

        protected Item(Position position, int itemCount) 
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
