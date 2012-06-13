using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreedomFarmer.GameObjects.Tools.WateringTools;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Tools.Nutrients
{
    /// <summary>
    /// Putting miracle grow on your plants is a noob move, this shit will kill your plants.
    /// </summary>
    public class MiracleGrow : BaseNutrientTool
    {
        public MiracleGrow(Game game)
            : base(game)
        {
            this.Ph = .5;
            this.NutritionValue = .01;

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);

            BaseWateringTool t = useWithThis as BaseWateringTool;

            if (t != null)
            {
                t.PH += this.Ph;
                t.WaterQuality += this.NutritionValue;
            }

        }
    }
}
