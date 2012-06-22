using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace FreedomFarmer.GameObjects
{
    public class BaseGameObject : Microsoft.Xna.Framework.GameComponent
    {
        public BaseGameObject(Game game, Vector2 start)
            : base(game)
        {
            
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        


        
        
    }
}
