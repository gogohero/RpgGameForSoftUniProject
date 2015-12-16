﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Hero3TrialMono.Characters;
using Hero3TrialMono.Interfaces;
using Hero3TrialMono.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Hero3TrialMono
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private List<ICharacter> characters;
        private List<Item> items;
        private bool isRuning;
        
        private Rectangle rect;
        private Texture2D image;
        private Warrior go6oWarrior = new Warrior(new Vector2(2,2),0,"go6o");

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            base.LoadContent();

            image = Content.Load<Texture2D>(go6oWarrior.Image);
            rect = new Rectangle(0, 0, 100, 100);

        }


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.characters = new List<ICharacter>();
            this.items = new List<Item>();
        }


        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            // TODO: Add your initialization logic here

            base.Initialize();
        }
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(image, go6oWarrior.Position, new Rectangle(0, 0, 400, 40),Color.White,0,new Vector2(10,10), new Vector2(1,1),SpriteEffects.None, 0);
              
            spriteBatch.End();
            KeyboardState KBS = Keyboard.GetState();
            //Moving
            Move(KBS);
        }

        public void Move(KeyboardState KBS)
        {

            int speed = 10;
            if (KBS.IsKeyDown(Keys.Right))
            {
                rect.X += speed;
            }
            else if (KBS.IsKeyDown((Keys.Left)))
            {
                rect.X -= speed;
            }

            else if (KBS.IsKeyDown(Keys.Down))
            {
                rect.Y += speed;
            }
            else if (KBS.IsKeyDown(Keys.Up))
            {
                rect.Y -= speed;
            }
            if (KBS.IsKeyDown(Keys.Right) && KBS.IsKeyDown(Keys.Down))
            {
                rect.Y += speed / 2;
                rect.X += 0;
            }
            if (KBS.IsKeyDown(Keys.Up) && KBS.IsKeyDown((Keys.Left)))
            {
                rect.Y -= speed / 2;
                rect.X -= 0;
            }
            if (KBS.IsKeyDown(Keys.Down) && KBS.IsKeyDown((Keys.Left)))
            {
                rect.Y += speed / 2;
                rect.X -= 0;
            }
            if (KBS.IsKeyDown(Keys.Up) && KBS.IsKeyDown((Keys.Right)))
            {
                rect.Y -= speed / 2;
                rect.X += 0;
            }
        }
    }
}
