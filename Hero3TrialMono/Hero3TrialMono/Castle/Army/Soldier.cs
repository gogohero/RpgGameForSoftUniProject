using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Hero3TrialMono.Castle.Army
{
    using Characters;
    using Interfaces;
    public class Soldier : GameObject, IMovable, IAttack
    {
        private string name;
        private int damage;
        private int health;
        private int defence;
        private int speed;

        public Soldier(Vector2 position, string name, int soldierCount, int damage, int health, int defence, int speed)
            : base(position)
        {
            this.Name = name;
            this.SoldierState = SoldierState.Buy;
            this.Damage = damage;
        }

        public int SoldierCount { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public SoldierState SoldierState { get; set; }

        public int Speed { get; set; }
        public void Move()
        {

        }


        public void Attack(Champion enemy)
        {
            
        }
    }
}
