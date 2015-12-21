using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hero3TrialMono.Characters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Hero3TrialMono
{
    public class Map:State
    {
        private int spritePosition = 1;
        private Texture2D background;
        private Texture2D playerImage;
        private Rectangle backgroundViewRectengel;
        private SpriteBatch PlayerBatch;
        private Rectangle playerViewRectangle;
        private Vector2 playerPosition;
        private Warrior go6oWarrior = new Warrior(new Vector2(-200, -300), 0, "go6o");
        
        public Map()
        {
        Initialize();
        }

        void Initialize()
        {
             background = Engine.ContentLoader.Content.Load<Texture2D>("Images/mapOne");
            playerImage = Engine.ContentLoader.Content.Load<Texture2D>("Images/Champion");
            playerViewRectangle = new Rectangle(0,0,100,150);
            backgroundViewRectengel = new Rectangle(0, 0, 3200, 3200);
            playerPosition = go6oWarrior.Position;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Matrix.CreateTranslation((float)(playerPosition.X+800), (float)(playerPosition.Y+650), 0));

            spriteBatch.Draw(background, new Vector2(-800,-650), backgroundViewRectengel, Color.White, 0, Vector2.Zero, Vector2.One, SpriteEffects.None, 1);
            spriteBatch.Draw(playerImage, go6oWarrior.Position,playerViewRectangle, Color.White, 0,playerPosition, new Vector2(1, 1), SpriteEffects.None, 0);
            KeyboardState KBS = Keyboard.GetState();
            //Moving
            Move(KBS);
            spriteBatch.End();

        }
//        

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {

        }
        public void Move(KeyboardState KBS)
        {

            int speed = 30;

            if (KBS.IsKeyDown(Keys.Right) && playerPosition.X>-1800)
            {
                if (spritePosition > 800)
                {
                    spritePosition = 1;
                }
                playerViewRectangle.X = spritePosition;
                playerPosition.X -= speed;
                spritePosition += 200;
            }
            else if (KBS.IsKeyDown(Keys.Left)&& playerPosition.X<-20)
            {
                playerPosition.X += speed;
            }

            if (KBS.IsKeyDown(Keys.Down) && playerPosition.Y > -2000)
                {
                    

                    playerPosition.Y -= speed;

                    
            }
            else if (KBS.IsKeyDown(Keys.Up) && playerPosition.Y < -20)
            {


                playerPosition.Y += speed;

            }
            if (KBS.IsKeyDown(Keys.Right) && KBS.IsKeyDown(Keys.Down) && playerPosition.Y > -2000)
            {
                playerPosition.Y -= speed / 2;
                playerPosition.X -= 0;
            }
            if (KBS.IsKeyDown(Keys.Up) && KBS.IsKeyDown((Keys.Left)) && playerPosition.Y < -20)
            {
                playerPosition.Y += speed / 2;
                playerPosition.X += 0;
            }
            if (KBS.IsKeyDown(Keys.Down) && KBS.IsKeyDown((Keys.Left)) && playerPosition.Y > -2000)
            {
                playerPosition.Y -= speed / 2;
                playerPosition.X += 0;
            }
            if (KBS.IsKeyDown(Keys.Up) && KBS.IsKeyDown((Keys.Right)) && playerPosition.Y < -20)
            {
                playerPosition.Y += speed / 2;
                playerPosition.X -= 0;
            }
        }
    }
}
