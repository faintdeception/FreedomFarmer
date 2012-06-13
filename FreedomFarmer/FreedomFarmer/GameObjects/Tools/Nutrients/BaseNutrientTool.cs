using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreedomFarmer.Interfaces;
using FreedomFarmer.GameObjects.Tools.WateringTools;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Tools.Nutrients
{
    public class BaseNutrientTool : BaseGameObject, IUseableTool
    {

        public BaseNutrientTool(Game game)
            : base(game)
        {
            
        }

        /// <summary>
        /// What's the ph of the nute.
        /// </summary>
        public double Ph { get; internal set; }

        /// <summary>
        /// How much nutrition does this add to the water?
        /// </summary>
        public double NutritionValue { get; internal set; }

        public virtual void Use(BaseGameObject useWithThis)
        {
            if (!(useWithThis is BaseWateringTool))
            {
                throw (new Exception("You can only use nutrients with watering tools."));
            }
        }
    }
}
