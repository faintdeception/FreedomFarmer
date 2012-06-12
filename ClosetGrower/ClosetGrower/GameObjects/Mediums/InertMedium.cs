using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Mediums
{
    public class InertMedium : BaseMedium
    {
        public InertMedium(Game game)
            : base(game)
        {
            Humdity = 0.0;
            Ph = 0.0;
        }
    }
}
