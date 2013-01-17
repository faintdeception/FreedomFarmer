using FreedomFarmer.GameObjects.Plants;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Seeds
{
    class PlantedWaterMelonSeed : PlantedSeedObject
    {
        public PlantedWaterMelonSeed(Game game, BasePlant plant, Vector2 start)
            : base(game, plant, start)
        {
            this.Plant = plant;
            FreedomFarmerGame cg = (FreedomFarmerGame)game;
            this.MoistureAbsorbtionRate = 0.066;
            this.Plant = new WaterMelonPlant(cg, start);
            this.MaxAge = 120;
        }        
    }
}
