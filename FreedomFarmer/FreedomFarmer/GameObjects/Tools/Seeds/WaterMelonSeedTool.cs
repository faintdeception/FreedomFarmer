using System;
using FreedomFarmer.GameObjects.Plants;
using FreedomFarmer.GameObjects.Pots;
using FreedomFarmer.GameObjects.Seeds;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Tools.Seeds
{
    public class WaterMelonSeedTool : BaseSeedTool
    {
        public WaterMelonSeedTool(Game game, Vector2 start)
            : base(game, start)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);
            BasePot p = useWithThis as BasePot;
            p.PlantSeed(new PlantedWaterMelonSeed(this.Game, new WaterMelonPlant(this.Game, new Vector2(0,0)), new Vector2(0,0)));            
        }
    }
}
