using Microsoft.Xna.Framework;
using FreedomFarmer.GameObjects.Pots;
using FreedomFarmer.GameObjects.WaterSources;

namespace FreedomFarmer.GameObjects.Tools.WateringTools
{
    public class EmptySodaBottleTool : BaseWateringTool
    {
        public EmptySodaBottleTool(Game game)
            : base(game)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);
            //Check to see what type of object it is the lazy way, if it's null it's not a pot.
            BasePot p = useWithThis as BasePot;
            if (p != null)
            {
                p.Water(0.01);
                this.RemainingWater -= 0.1;
                return;
            }
            BaseWaterSource s = useWithThis as BaseWaterSource;

            if (s != null)
            {
                this.RemainingWater = 1.0;
                this.WaterQuality = s.Quality;
            }
        }
    }
}
