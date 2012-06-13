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
    public class HydroponicMediumTool : BaseMediumTool
    {
        public HydroponicMediumTool(Game game)
            : base(game)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);
            BasePot p = useWithThis as BasePot;
            p.AddGrowMedium(new HydroponicMedium(this.Game));
        }
    }
}
