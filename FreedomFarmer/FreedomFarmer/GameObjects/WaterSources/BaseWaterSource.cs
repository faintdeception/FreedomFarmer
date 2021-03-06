﻿using Microsoft.Xna.Framework;
using FreedomFarmer.GameObjects.Tools.WateringTools;

namespace FreedomFarmer.GameObjects.WaterSources
{
    public class BaseWaterSource : BaseGameObject
    {
        public BaseWaterSource(Game game, Vector2 start)
            : base(game, start)
        {
            this.Output = .1;
        }

        public double Output{get;set;}


        public void Fill(BaseWateringTool container)
        {
            container.RemainingWater+= this.Output; 
        }

        /// <summary>
        /// Quality of the water from this water source.
        /// </summary>
        public double Quality { get; internal set; }
    }
}
