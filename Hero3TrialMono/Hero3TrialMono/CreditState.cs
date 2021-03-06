﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class CreditState :State
    {

        private Texture2D credits;


        public CreditState()
        {

            Initialize();

        }

        private void Initialize()
        {
            this.credits = Engine.ContentLoader.Content.Load<Texture2D>("Images/credits");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.credits, new Vector2(0, 0), Color.White);
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {

        }

    }
}
