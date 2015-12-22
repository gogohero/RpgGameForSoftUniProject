using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GameInfoState : State
    {
        private Texture2D gameInfo;

        public GameInfoState()
        {

            Initialize();

        }

        private void Initialize()
        {
            this.gameInfo = Engine.ContentLoader.Content.Load<Texture2D>("Images/gamePlayInfo");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.gameInfo, new Vector2(0, 0), Color.White);
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {

        }
    }
}
