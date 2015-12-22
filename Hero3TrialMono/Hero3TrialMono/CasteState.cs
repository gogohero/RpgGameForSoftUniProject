using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class CastleState : State
    {
        private Texture2D castle;

        public CastleState()
        {

            Initialize();
        }

        private void Initialize()
        {
            this.castle = Engine.ContentLoader.Content.Load<Texture2D>("Images/AngelCastle");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(castle, new Vector2(0, 0), Color.White);
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {

        }
    }
}
