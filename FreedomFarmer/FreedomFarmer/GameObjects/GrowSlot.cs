using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace FreedomFarmer.GameObjects
{
    class GrowSlot : BaseGameObject
    {
         public GrowSlot(Game game, Closet closet, Vector2 start)
            : base(game, start)
        {
            // TODO: Construct any child components here
        }

         public Rectangle BoundingRectangle { get; set; }

         internal void Draw(GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
         {
             throw new System.NotImplementedException();
         }

         public void Update(GameTime gameTime, KeyboardState keyboardState, GamePadState gamepadState)
         {
             base.Update(gameTime);
         }
    }
}
