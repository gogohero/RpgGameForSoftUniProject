using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hero3TrialMono
{
    using System.IO;
    using System.Reflection;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class MenuState : State
    {
        private Texture2D backGround;
        private Texture2D Play;
        private Texture2D Overview;
        private Texture2D credits;

        public MenuState()
        {
          Initialize();  
        }

        private void Initialize()
        {
            this.backGround = base.Content.Load<Texture2D>("Images/background");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.backGround, new Vector2(0 ,0 ),Color.White);
        }

        public override void Update(GameTime gameTime)
        {
           
        }

    }
}
