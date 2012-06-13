using System;
using FreedomFarmer.GameObjects.Plants;
using FreedomFarmer.GameObjects.Pots;
using FreedomFarmer.GameObjects.Seeds;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Tools.Seeds
{
    public class LaughingBuddhaSeedTool : BaseSeedTool
    {
        public LaughingBuddhaSeedTool(Game game)
            : base(game)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);
            //ToDo: Change this to a laughing buddha seed and plant.
            BasePot p = useWithThis as BasePot;
            p.PlantSeed(new PlantedSeedObject(this.Game, new BasePlant(this.Game)));           

        }
    }
}
