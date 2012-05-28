using ClosetGrower.GameObjects.Plants;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Seeds
{
    class PlantedWhiteWidowSeed : PlantedSeedObject
    {
        public PlantedWhiteWidowSeed(Game game, BasePlant plant)
            : base(game, plant)
        {
            this.Plant = plant;
            ClosetGrow cg = (ClosetGrow)game;
            this.MoistureAbsorbtionRate = 0.066;

            this.MaxAge = 120;
        }        
    }
}
