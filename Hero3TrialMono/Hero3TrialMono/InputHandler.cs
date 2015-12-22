using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using Characters;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class InputHandler
    {
        private GraphicsDeviceManager graphics;
        private MouseState oldMouseState;
        private StateManager stateManager;
        private State currentState;
        private Engine engine;
        private ContentManager content;
        

        public InputHandler(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
           
        }

        public void CheckForKeyboardInput(StateManager stateManager)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.P))
            {
                stateManager.CurrentState = new CharacterMenuState();
                this.graphics.ApplyChanges();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.C) &&
                stateManager.CurrentState is MenuState)
            {
                stateManager.CurrentState = new CreditState();
                this.graphics.PreferredBackBufferWidth = 660;
                this.graphics.PreferredBackBufferHeight = 451;
                graphics.ApplyChanges();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.E) &&
                stateManager.CurrentState is Map)
            {

                stateManager.CurrentState = new CastleState();
                this.graphics.PreferredBackBufferWidth = 1024;
                this.graphics.PreferredBackBufferHeight = 477;

                graphics.ApplyChanges();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.G) &&
               stateManager.CurrentState is MenuState)
            {
                stateManager.CurrentState = new GameInfoState();
                this.graphics.PreferredBackBufferWidth = 781;
                this.graphics.PreferredBackBufferHeight = 451;
                this.graphics.ApplyChanges();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.W) &&
               stateManager.CurrentState is CharacterMenuState)
            {
                stateManager.CurrentState = new Map();
                this.graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
                this.graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
                this.graphics.IsFullScreen = true;
                graphics.ApplyChanges();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.A) &&
              stateManager.CurrentState is CharacterMenuState)
            {

            }
            else if (Keyboard.GetState().IsKeyDown(Keys.H) &&
              stateManager.CurrentState is MenuState)
            {

            }
        }

        //public void PlayerMovement(Player player)
        //{
        //    if (Keyboard.GetState().IsKeyDown(Keys.Up))
        //    {
        //        player.IsMovingUp = true;
        //    }
        //    if (Keyboard.GetState().IsKeyDown(Keys.Down))
        //    {
        //        player.IsMovingDown = true;
        //    }
        //    if (Keyboard.GetState().IsKeyDown(Keys.Left))
        //    {
        //        player.IsMovingLeft = true;
        //    }

        //    if (Keyboard.GetState().IsKeyDown(Keys.Right))
        //    {
        //        player.IsMovingRight = true;
        //    }

        //}

        //public void CheckForMouseInput(StateManager stateManager)
        //{
        //    MouseState newMouseState = Mouse.GetState();

        //    if (newMouseState.X < 500 &&
        //        oldMouseState.LeftButton == ButtonState.Pressed &&
        //        newMouseState.LeftButton == ButtonState.Released)
        //    {
        //        stateManager.CurrentState = new GameState(stateManager.Content);

        //    }
        //    this.oldMouseState = newMouseState;

        //}
        public void MouseMovement()
        {


            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Keyboard.GetState().IsKeyDown(Keys.Enter) || mouseState.LeftButton == ButtonState.Pressed
                && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) -400 , (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 260, 100, 70).Contains(mousePosition)))
            {
        
               
                Mouse.SetPosition(0,0);
            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 30, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 150, 100, 70)).Contains(mousePosition))
            {
               // Mouse.SetPosition(0, 0);
            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 30, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2), -30, 70).Contains(mousePosition)))
            {
              //  MenuState.stopMenu = true;
            }

        }
    }
}
