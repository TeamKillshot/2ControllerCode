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
        public PlayerIndex index;

        int playerNumber = 0;

        public List<Player> playerList = new List<Player>();

        private static Vector2 prevPosition;
        private static Vector2 currentPosition;

        private static Vector2 P2prevPosition;
        private static Vector2 P2currentPosition;

        Player player;

        //SpriteBatch _spritebatch;
        //GraphicsDevice _graphics;

        private float speed = 15f;

        public Player(Game _game)
            : base (_game)
        {
            GamePad.GetState(index);
            _game.Components.Add(this);
        }

        public void GetPlayerPosition(Vector2 pos)
        {
            currentPosition = new Vector2(25, 25);
            P2currentPosition = new Vector2(150, 150);
        }

        public void IsControllerDetected(List<Player> tempList)
        {
            GamePadState state = GamePad.GetState(PlayerIndex.One);
            GamePadState state2 = GamePad.GetState(PlayerIndex.Two);
            GamePadState state3 = GamePad.GetState(PlayerIndex.Three);
            GamePadState state4 = GamePad.GetState(PlayerIndex.Four);

            GetPlayerIndex(tempList, player);

            #region Controller Detection

            //if (state.IsConnected)
            //{
            //    playerList.Add(player1);
            //}
            //if (state2.IsConnected)
            //{
            //    playerList.Add(player2);
            //}
            //if (state3.IsConnected)
            //{
            //    playerList.Add(player3);
            //}
            //if (state4.IsConnected)
            //{
            //    playerList.Add(player4);
            //}

            #endregion
        }

        public void GetPlayerIndex(List<Player> playersList, Player tempPlayer)
        {

        }

        public void Update(GameTime gameTime, PlayerIndex player, List<Player> playersList)
        {
            prevPosition = currentPosition;
            P2prevPosition = P2currentPosition;

            IsControllerDetected(playersList);

            //GamePadState state = GamePad.GetState(PlayerIndex.One);
            //GamePadState state2 = GamePad.GetState(PlayerIndex.Two);
            //GamePadState state3 = GamePad.GetState(PlayerIndex.Three);
            //GamePadState state4 = GamePad.GetState(PlayerIndex.Four);

            #region Player Counts for Indexing

            //if (playerList.Count <= 1)
            //{
            //    playerNumber = 1;
            //    player = PlayerIndex.One;
            //}
            //else if (playerList.Count == 2)
            //{
            //    playerNumber = 2;
            //    player = PlayerIndex.Two;
            //}
            //else if (playerList.Count == 3)
            //{
            //    playerNumber = 3;
            //    player = PlayerIndex.Three;
            //}
            //else if (playerList.Count == 4)
            //{
            //    playerNumber = 4;
            //    player = PlayerIndex.Four;
            //}
            #endregion

            #region Player1 Controller
            foreach (Player players in playersList)
            {
                if (InputManager.IsButtonPressed(Buttons.DPadRight, players.index))
                {
                    currentPosition.X += speed;
                }
                if (InputManager.IsButtonPressed(Buttons.DPadLeft, players.index))
                {
                    currentPosition.X -= speed;
                }
                if (InputManager.IsButtonPressed(Buttons.DPadDown, players.index))
                {
                    currentPosition.Y += speed;
                }
                if (InputManager.IsButtonPressed(Buttons.DPadUp, players.index))
                {
                    currentPosition.Y -= speed;
                }
            }
            
                #endregion

            //else if (player == PlayerIndex.Two)
            //{
               #region Player2 Controller

            //    //if (InputManager.IsButtonPressed(Buttons.DPadRight, player))
            //    //{
            //    //    currentPosition.X += speed;
            //    //}
            //    //if (InputManager.IsButtonPressed(Buttons.DPadLeft, player))
            //    //{
            //    //    currentPosition.X -= speed;
            //    //}
            //    //if (InputManager.IsButtonPressed(Buttons.DPadDown, player))
            //    //{
            //    //    currentPosition.Y += speed;
            //    //}
            //    //if (InputManager.IsButtonPressed(Buttons.DPadUp, player))
            //    //{
            //    //    currentPosition.Y -= speed;
            //    //}
               #endregion
            //}
        }

        public void Draw(GameTime gameTime, SpriteFont font, SpriteBatch _spritebatch)
        {
            _spritebatch.Begin();

            foreach (Player player in playerList)
            {
                //playerNumber++;
                _spritebatch.DrawString(font, "Player" + playerNumber, currentPosition, Color.Red);
            }
            //_spritebatch.DrawString(font, "Player1", currentPosition, Color.Red);
            //_spritebatch.DrawString(font, "Player2", P2currentPosition, Color.Blue);
            _spritebatch.End();
        }
    }
}
