using Engine.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace _2_Controller_Attempt
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont font;
        public Player player, player1, player2, player3, player4;

        public List<Player> playerList = new List<Player>();

        PlayerIndex playerIndex;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            new InputManager(this);
            player = new Player(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            font = Content.Load<SpriteFont>("SystemFont");

            player1 = new Player(this);
            player2 = new Player(this);
            player3 = new Player(this);
            player4 = new Player(this);

            playerList.Add(player1);
            playerList.Add(player2);
            playerList.Add(player3);
            playerList.Add(player4);

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

            player.Update(gameTime, playerIndex);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            player.Draw(gameTime, font, spriteBatch);

            base.Draw(gameTime);
        }
    }
}
