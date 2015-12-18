using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Interfaces;
    using Microsoft.Xna.Framework.Content;

    public  class StateManager 
    {
        private State currentState;
        private ContentManager content;

        public StateManager(ContentManager content)
        {
            this.Content = content;
            this.currentState = new MenuState(this.Content);
            //this.currentState = new CharacterMenuState();
            
        }

        public ContentManager Content { get; set; }

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }
    }
}
