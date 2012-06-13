using System;
using FreedomFarmer.GameObjects.Pots;
using Microsoft.Xna.Framework;
using FreedomFarmer.GameObjects.WaterSources;
using FreedomFarmer.Interfaces;

namespace FreedomFarmer.GameObjects.Tools.WateringTools
{
    public class BaseWateringTool : BaseGameObject, IUseableTool
    {
        public BaseWateringTool(Game game)
            : base(game)
        {

        }

        /// <summary>
        /// The quality of the water in the tool.
        /// </summary>
        public double WaterQuality { get; set; }

        /// <summary>
        /// The PH of the water in the tool.
        /// </summary>
        public double PH { get; set; }

        /// <summary>
        /// How much water is left in the container?
        /// </summary>
        public double RemainingWater { get; set; }

        public virtual void Use(BaseGameObject useWithThis)
        {

            if (!(useWithThis is BasePot) && !(useWithThis is BaseWaterSource))
            {
                throw (new Exception("You can only use watering tools with pots or watering sources."));
            }

        }
    }
}
