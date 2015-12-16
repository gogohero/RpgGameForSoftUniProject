using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class State : IContent
    {
        private readonly ContentManager content;

        protected State()
        {
            this.content = Engine.ContentLoader.Content;
        }

        public ContentManager Content => this.content;

        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update(GameTime gameTime);
    }
}

