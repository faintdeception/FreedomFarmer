using FreedomFarmer.Enums;
using Microsoft.Xna.Framework;

namespace FreedomFarmer.GameObjects.Mediums
{
    public class BaseMedium : BaseGameObject
    {
        public BaseMedium(Game game)
            : base(game)
        {            
            
        }

        /// <summary>
        /// What type of medium is it?
        /// </summary>
        public GrowMediumType Type { get; set; }
        
        /// <summary>
        /// The PH of the medium.
        /// </summary>
        public double Ph { get; set; }

        /// <summary>
        /// How moist is the medium.
        /// </summary>
        public double Humdity { get; set; }

        /// <summary>
        /// What's the nutrient level
        /// </summary>
        public double NutritionLevel { get; set; } 
    }
}
