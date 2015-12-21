using System.Collections.Generic;
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
    public class Engine : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        private StateManager stateManager;
        private InputHandler input;
        public static ContentLoader ContentLoader;

        public Engine()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
            input = new InputHandler(graphics);
            this.graphics.PreferredBackBufferWidth = 800;
            this.graphics.PreferredBackBufferHeight = 600;
            this.graphics.ApplyChanges();
          

            this.IsMouseVisible = true;

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            ContentLoader = new ContentLoader(this.Content);

            this.stateManager = new StateManager(this.Content);
            this.input = new InputHandler(this.graphics);

           

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            this.Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// 
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            input.MouseMovement();
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
                this.IsMouseVisible = true;
          
              
            this.stateManager.CurrentState.Update(gameTime, this.input);
           this.input.CheckForKeyboardInput(this.stateManager);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.CornflowerBlue);
           
            this.stateManager.CurrentState.Draw(this.spriteBatch);

            base.Draw(gameTime);
        }
    }
}