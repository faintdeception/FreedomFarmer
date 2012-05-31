using Microsoft.Xna.Framework;
using ClosetGrower.GameObjects.Tools.WateringTools;

namespace ClosetGrower.GameObjects.WaterSources
{
    public class BaseWaterSource : BaseGameObject
    {
        public BaseWaterSource(Game game)
            : base(game)
        {
            this.Output = .1;
        }

        public double Output{get;set;}


        public void Fill(BaseWateringTool container)
        {
            container.RemainingWater+= this.Output; 
        }

        /// <summary>
        /// Quality of the water from this water source.
        /// </summary>
        public double Quality { get; internal set; }
    }
}
