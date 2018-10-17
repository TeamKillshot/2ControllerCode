using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Managers;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace _2_Controller_Attempt
{
    public sealed class Player : GameComponent
    {
        #region Properties and Variables

        public PlayerIndex index;

        int playerNumber = 0;

        public string Name { get; set; }

        public List<Player> playerList = new List<Player>();

        public Vector2 previousPosition;
        public Vector2 currentPosition;

        Player player;

        private float speed = 15f;
        #endregion

        public Player(Game _game)
            : base (_game)
        {
            GamePad.GetState(index);
            _game.Components.Add(this);
        }

        public void GetPlayerPosition(Vector2 pos)
        {
            currentPosition = new Vector2(25, 25);
        }

        public void GetPlayerIndex(Player tempPlayer)
        {
            #region Check GameStates
            GamePadState state = GamePad.GetState(PlayerIndex.One);
            GamePadState state2 = GamePad.GetState(PlayerIndex.Two);
            GamePadState state3 = GamePad.GetState(PlayerIndex.Three);
            GamePadState state4 = GamePad.GetState(PlayerIndex.Four);
            #endregion

            if (tempPlayer.Name == "Player1" && state.IsConnected)
            {
                tempPlayer.index = PlayerIndex.One;
                playerList.Add(tempPlayer);
            }
            else if(tempPlayer.Name == "Player2" && state2.IsConnected)
            {
                tempPlayer.index = PlayerIndex.Two;
                playerList.Add(tempPlayer);
            }
            else if(tempPlayer.Name == "Player3" && state.IsConnected)
            {
                tempPlayer.index = PlayerIndex.Three;
                playerList.Add(tempPlayer);
            }
            else if (tempPlayer.Name == "Player4" && state.IsConnected)
            {
                tempPlayer.index = PlayerIndex.Four;
                playerList.Add(tempPlayer);
            }
        }

        public void Update(GameTime gameTime, PlayerIndex player)
        {
            previousPosition = currentPosition;

            #region Player1 Controller
            foreach (Player players in playerList)
            {
                if (InputManager.IsButtonPressed(Buttons.DPadRight, players.index))
                {
                    players.currentPosition.X += speed;
                }
                if (InputManager.IsButtonPressed(Buttons.DPadLeft, players.index))
                {
                    players.currentPosition.X -= speed;
                }
                if (InputManager.IsButtonPressed(Buttons.DPadDown, players.index))
                {
                    players.currentPosition.Y += speed;
                }
                if (InputManager.IsButtonPressed(Buttons.DPadUp, players.index))
                {
                    players.currentPosition.Y -= speed;
                }
            }
            
                #endregion
        }

        public void Draw(GameTime gameTime, SpriteFont font, SpriteBatch _spritebatch)
        {
            _spritebatch.Begin();

            foreach (Player player in playerList)
            {
                _spritebatch.DrawString(font, player.Name, currentPosition, Color.Red);
            }
            _spritebatch.End();
        }
    }
}
