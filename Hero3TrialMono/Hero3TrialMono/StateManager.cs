using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Interfaces;
    using Microsoft.Xna.Framework.Content;

    public  class StateManager : IContent
    {
        private State currentState;
        private ContentManager content;

        public StateManager()
        {
            this.content = Engine.ContentLoader.Content;
            this.currentState = new MenuState();
        }

        public ContentManager Content => this.content;

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }
    }
}
