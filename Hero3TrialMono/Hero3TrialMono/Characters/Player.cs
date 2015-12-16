using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Interfaces;

namespace Hero3TrialMono.Characters
{
    using Items;

    public abstract class Player : GameObject, ICharacter, IPlayer
    {
        private int gold;
        private int crystals;
        private int mercury;
        private int sulfur;
        private int wood;
        private int rock;
        private int jems;
        

        public Player(Position position, 
            int damage, 
            string name,
            int gold,
            int crystals,
            int mercury,
            int sulfur,
            int wood,
            int rock,
            int jems) 
            : base(position)
        {
            this.Damage = damage;
            this.Name = name;
        
        }

        public int Expirience { get; }

        public int Damage { get; }

        public Position Position { get; }

        public string Name { get; }

        public void Attack(Player enemy)
        {
            throw new NotImplementedException();
        }


        public void Move()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Item> suplys { get; }

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
