using System;
using FreedomFarmer.GameObjects.Plants;
using FreedomFarmer.GameObjects.Pots;
using FreedomFarmer.GameObjects.Seeds;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Tools.Seeds
{
    public class WhiteWidowSeedTool : BaseSeedTool
    {
        public WhiteWidowSeedTool(Game game, Vector2 start)
            : base(game, start)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);
            BasePot p = useWithThis as BasePot;
            p.PlantSeed(new PlantedWhiteWidowSeed(this.Game, new WhiteWidowPlant(this.Game, new Vector2(0,0)), new Vector2(0,0)));            
        }
    }
}
