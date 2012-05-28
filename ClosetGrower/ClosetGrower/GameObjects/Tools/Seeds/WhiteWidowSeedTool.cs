using System;
using ClosetGrower.GameObjects.Plants;
using ClosetGrower.GameObjects.Pots;
using ClosetGrower.GameObjects.Seeds;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Tools.Seeds
{
    public class WhiteWidowSeedTool : BaseSeedTool
    {
        public WhiteWidowSeedTool(Game game)
            : base(game)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            BasePot p = useWithThis as BasePot;
            p.PlantSeed(new PlantedWhiteWidowSeed(this.Game, new WhiteWidowPlant(this.Game)));            
        }
    }
}
