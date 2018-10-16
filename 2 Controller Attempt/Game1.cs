using Engine.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace _2_Controller_Attempt
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont font;
        Vector2 player1Position;
        Vector2 player2Position;
        float speed;

        //PlayerIndex currentIndex;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            new InputManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            player1Position = new Vector2(20, 20);
            player2Position = new Vector2(120, 150);
            speed = 10f;
            font = Content.Load<SpriteFont>("SystemFont");
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            #region Player1 Controller
            if(GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed)
            {
                player1Position.Y += speed;
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed)
            {
                player1Position.Y -= speed;
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed)
            {
                player1Position.Y -= speed;
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
            {
                player1Position.Y += speed;
            }
            #region Using Input Manager
            //if(InputManager.IsButtonPressed(Buttons.DPadRight, PlayerIndex.One))
            //{
            //    player1Position.X += speed;
            //}
            //if (InputManager.IsButtonPressed(Buttons.DPadLeft, PlayerIndex.One))
            //{
            //    player1Position.X -= speed;
            //}
            //if (InputManager.IsButtonPressed(Buttons.DPadDown, PlayerIndex.One))
            //{
            //    player1Position.Y -= speed;
            //}
            //if (InputManager.IsButtonPressed(Buttons.DPadUp, PlayerIndex.One))
            //{
            //    player1Position.Y += speed;
            //}
            #endregion
            #endregion

            #region Player2 Controller
            if (GamePad.GetState(PlayerIndex.Two).DPad.Up == ButtonState.Pressed)
            {
                player2Position.Y += speed;
            }
            if (GamePad.GetState(PlayerIndex.Two).DPad.Down == ButtonState.Pressed)
            {
                player2Position.Y -= speed;
            }
            if (GamePad.GetState(PlayerIndex.Two).DPad.Right == ButtonState.Pressed)
            {
                player2Position.Y -= speed;
            }
            if (GamePad.GetState(PlayerIndex.Two).DPad.Left == ButtonState.Pressed)
            {
                player2Position.Y += speed;
            }

            #region Using Input Manager
            //if (InputManager.IsButtonPressed(Buttons.DPadRight, PlayerIndex.Two))
            //{
            //    player1Position.X += speed;
            //}
            //if (InputManager.IsButtonPressed(Buttons.DPadLeft, PlayerIndex.Two))
            //{
            //    player1Position.X -= speed;
            //}
            //if (InputManager.IsButtonPressed(Buttons.DPadUp, PlayerIndex.Two))
            //{
            //    player1Position.Y -= speed;
            //}
            //if (InputManager.IsButtonPressed(Buttons.DPadDown, PlayerIndex.Two))
            //{
            //    player1Position.Y += speed;
            //}
            #endregion
            #endregion


            #region Player1 Keyboard
            //Using Input Manager
            if (InputManager.IsKeyHeld(Keys.W))
            {
                player1Position.Y -= speed;
            }
            if (InputManager.IsKeyHeld(Keys.S))
            {
                player1Position.Y += speed;
            }
            if (InputManager.IsKeyHeld(Keys.A))
            {
                player1Position.X -= speed;
            }
            if (InputManager.IsKeyHeld(Keys.D))
            {
                player1Position.X += speed;
            }
            #endregion

            #region Player2 Keyboard
            //Using Input Manager
            if (InputManager.IsKeyHeld(Keys.Up))
            {
                player2Position.Y -= speed;
            }
            if (InputManager.IsKeyHeld(Keys.Down))
            {
                player2Position.Y += speed;
            }
            if (InputManager.IsKeyHeld(Keys.Right))
            {
                player2Position.X += speed;
            }
            if (InputManager.IsKeyHeld(Keys.Left))
            {
                player2Position.X -= speed;
            }
            #endregion

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //Console.WriteLine("Hi");
            //Console.ReadLine();
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Player1", player1Position, Color.Red);
            spriteBatch.DrawString(font, "Player2", player2Position, Color.Blue);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
