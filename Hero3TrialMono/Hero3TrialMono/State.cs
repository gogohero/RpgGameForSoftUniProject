﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class State 
    {
        private ContentManager content;

        protected State()
        {

        }

        public ContentManager Content
        {
            protected get { return this.content; }
            set { this.content = value; }
        }

        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update(GameTime gameTime, InputHandler inputHandler);
    }
}

