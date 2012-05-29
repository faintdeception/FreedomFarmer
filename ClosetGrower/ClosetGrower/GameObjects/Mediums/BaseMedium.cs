using ClosetGrower.Enums;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Mediums
{
    class BaseMedium : BaseGameObject
    {
        public BaseMedium(Game game)
            : base(game)
        {            
            
        }

        public GrowMediumType Type { get; set; }
        public double Ph { get; set; }
        public double Humdity { get; set; }        
    }
}
