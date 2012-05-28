using Microsoft.Xna.Framework;
using System;

namespace ClosetGrower.GameObjects.Plants
{
    class WhiteWidowPlant : BasePlant
    {
        public WhiteWidowPlant(Game game)
            : base(game)
        {
            this.MoistureAbsorbtionRate = .65;
        }

        public override void Game_DayIncrimented(object sender, EventArgs e)
        {
            //The logic for plants is probably going to be pretty complex, but basically it's going to feed, and then it's going to grow.
            //this.            
        }
    }
}
