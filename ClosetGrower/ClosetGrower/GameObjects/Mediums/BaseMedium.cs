using ClosetGrower.Enums;

namespace ClosetGrower.GameObjects.Mediums
{
    class BaseMedium
    {
        public GrowMediumType Type { get; set; }
        public double Ph { get; set; }
        public double Humdity { get; set; }        
    }
}
