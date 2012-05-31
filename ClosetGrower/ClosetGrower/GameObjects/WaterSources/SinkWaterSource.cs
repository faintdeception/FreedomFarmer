using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.WaterSources
{
    public class SinkWaterSource : BaseWaterSource
    {
        public SinkWaterSource(Game game)
            : base(game)
        {
            this.Quality = 0.5;
        }


    }
}
