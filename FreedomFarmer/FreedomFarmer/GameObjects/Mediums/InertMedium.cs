using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Mediums
{
    public class InertMedium : BaseMedium
    {
        public InertMedium(Game game, Vector2 start)
            : base(game, start)
        {
            Humdity = 0.0;
            Ph = 0.0;
        }
    }
}
