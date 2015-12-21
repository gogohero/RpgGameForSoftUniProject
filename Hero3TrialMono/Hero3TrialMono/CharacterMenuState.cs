using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class CharacterMenuState : State
    {
      

         private Texture2D warrior;
        private Texture2D archer;
        private Texture2D healer;
        

        public CharacterMenuState()
        {
           
            Initialize();
           
        }

        private void Initialize()
        {
           
            this.warrior = Engine.ContentLoader.Content.Load<Texture2D>("Images/warrior");
            this.archer = Engine.ContentLoader.Content.Load<Texture2D>("Images/archer");
            this.healer = Engine.ContentLoader.Content.Load<Texture2D>("Images/healer");

        }

        public override void Draw(SpriteBatch spriteBatch)
        {

          spriteBatch.Begin();
            spriteBatch.Draw(this.warrior, new Vector2(270, 140), Color.White);
            spriteBatch.Draw(this.archer, new Vector2(270, 250), Color.White);
            spriteBatch.Draw(this.healer, new Vector2(270, 370), Color.White);
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {
            
        }

       
    }
}
