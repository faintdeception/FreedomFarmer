using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace FreedomFarmer.GameObjects
{
    public class VisualGameObject : BaseGameObject
    {
        public VisualGameObject(Game game, Vector2 start)
            : base(game, start)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Handles input, performs physics, and animates the player sprite.
        /// </summary>
        /// <remarks>
        /// We pass in all of the input states so that our game is only polling the hardware
        /// once per frame. We also pass the game's orientation because when using the accelerometer,
        /// we need to reverse our motion when the orientation is in the LandscapeRight orientation.
        /// </remarks>
        public void Update(
            GameTime gameTime,
            KeyboardState keyboardState,
            GamePadState gamePadState)
        {
            base.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

        }
    }

}
