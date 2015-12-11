using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Interfaces;

namespace Hero3TrialMono.Characters
{
    using Items;

    public abstract class Champion : GameObject, ICharacter, IPlayer
    {
        private int gold;
        private int crystals;
        private int mercury;
        private int sulfur;
        private int wood;
        private int rock;
        private int jems;


        public Champion(Position position, int damage, string name) 
            : base(position)
        {
            this.Damage = damage;
            this.Name = name;
        
        }

        public int Expirience { get; }

        public int Damage { get; }

        public Position Position { get; }

        public string Name { get; }

        public IEnumerable<Item> suplys { get; }

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
