using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Tools.Seeds
{
    public class WhiteWidowSeedTool : BaseToolObject
    {
        public WhiteWidowSeedTool(Game game)
            : base(game)
        {

        }

        protected override void Use(BaseGameObject useWithThis)
        {
            if (useWithThis.GetType() == typeof(Pot))
            {
                Pot p = useWithThis as Pot;
                p.PlantSeed(new PlantedSeedObject(this.Game, new PlantObject(this.Game)));
            }
            else
            {
                throw(new Exception("You can only use seeds with pots"));
            }

        }
    }
}
