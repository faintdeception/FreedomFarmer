using Microsoft.Xna.Framework;
using System;

namespace FreedomFarmer.GameObjects.Plants
{
    class WaterMelonPlant : BasePlant
    {
        public WaterMelonPlant(Game game, Vector2 start)
            : base(game, start)
        {
            this.MoistureAbsorbtionRate = .08;
        }

        public override void Game_DayIncrimented(object sender, EventArgs e)
        {
            //The logic for plants is probably going to be pretty complex, but basically it's going to feed, and then 
            //it's going to grow.
            
            //this.

            
        }
    }
}
