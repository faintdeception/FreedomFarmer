using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Mediums
{
    class PHBalancedSoil : BaseMedium
    {
        public PHBalancedSoil(Game game, Vector2 start)
            : base(game, start)
        {
            Ph = 0.5;
            Humdity = 0.0;
        }
    }
}
