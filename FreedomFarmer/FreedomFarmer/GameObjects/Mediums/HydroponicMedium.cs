using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Mediums
{
    public class HydroponicMedium : BaseMedium
    {
        public HydroponicMedium(Game game, Vector2 start)
            : base(game, start)
        {
            Humdity = 1.0;
            Ph = 0.5;
        }
    }
}
