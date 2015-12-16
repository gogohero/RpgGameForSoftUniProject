using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Interfaces;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Characters
{
    using Items;

    public abstract class Champion : GameObject, IPlayer
    {
        private int gold;
        private int crystals;
        private int mercury;
        private int sulfur;
        private int wood;
        private int rock;
        private int jems;


        public Champion(Vector2 position, int damage, string name) 
            : base(position)
        {
            this.Damage = damage;
            this.Name = name;
        
        }

        public Vector2 Position { get; private set; }
        public string Name { get; set; }
       
        public int Expirience { get; set; }

        public int Damage { get; set; }

      

        public IEnumerable<Item> suplys { get; set; }

        public void Attack(Champion enemy)
        {
            throw new NotImplementedException();
        }


        public void Move()
        {
            throw new NotImplementedException();
        }


        public void addToSuplies(Item suply, int count)
        {
            throw new NotImplementedException();
        }

      
        public void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
