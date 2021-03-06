﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Interfaces;
using Microsoft.Xna.Framework;

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


        public Player(Vector2 position, int damage, string name)
            : base(position)
        {
            this.Damage = damage;
            this.Name = name;
            this.Delay = 1000f;
        }

        public float Elapsed { get; set; }
        public string Name { get; set; }

        public int Expirience { get; set; }

        public int Damage { get; set; }
        public float Delay { get; set; }


        public IEnumerable<Item> suplys { get; set; }

        public void Attack(Player enemy)
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
