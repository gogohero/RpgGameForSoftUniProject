using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
   public class Hero
    {
        private int heroDamage ;
        private int heroArmor;
        

        private string name;
        private bool dayTrun;
        

        public Hero(string name)
        {
            this.Name = name;
            this.heroArmor = 0;
            this.heroDamage = 0;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Name should be containt 3 or more Characters");
                }
                this.name = value;
            }
        }
    }
}
