using System;
using ClosetGrower.GameObjects.Pots;
using Microsoft.Xna.Framework;
using ClosetGrower.GameObjects.WaterSources;
using ClosetGrower.Interfaces;

namespace ClosetGrower.GameObjects.Tools.WateringTools
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
