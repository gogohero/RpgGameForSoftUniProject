using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hero3TrialMono
{
    using System.IO;
    using System.Reflection;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class MenuState : State
    {
      //  private Texture2D backGround;
        private Texture2D play;
        private Texture2D gameinfo;
        private Texture2D credit;
        

        public MenuState(ContentManager content)
        {
            base.Content = content;
          Initialize();  
        }

        private void Initialize()
        {
            this.play = base.Content.Load<Texture2D>("Images/play");
            this.gameinfo = base.Content.Load<Texture2D>("Images/gameinfo");
            this.credit =  base.Content.Load<Texture2D>("Images/credit");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(this.play, new Vector2(270 ,140 ),Color.White);
            spriteBatch.Draw(this.gameinfo, new Vector2(270,250),Color.White);
            spriteBatch.Draw(this.credit, new Vector2(270 ,370),Color.White);
          
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {
           
        }

    }
}
