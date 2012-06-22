using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.WaterSources
{
    public class SinkWaterSource : BaseWaterSource
    {
        public SinkWaterSource(Game game, Vector2 start)
            : base(game, start)
        {
            this.Quality = 0.5;
        }


    }
}
