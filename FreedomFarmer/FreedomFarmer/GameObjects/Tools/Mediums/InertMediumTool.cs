using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using FreedomFarmer.GameObjects.Pots;
using FreedomFarmer.GameObjects.Mediums;
using FreedomFarmer.Interfaces;

namespace FreedomFarmer.GameObjects.Tools.Mediums
{
    public class InertMediumTool : BaseMediumTool
    {
        public InertMediumTool(Game game, Vector2 start)
            : base(game, start)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);
            BasePot p = useWithThis as BasePot;
            p.AddGrowMedium(new InertMedium(this.Game, new Vector2(0,0)));
        }
    }
}
