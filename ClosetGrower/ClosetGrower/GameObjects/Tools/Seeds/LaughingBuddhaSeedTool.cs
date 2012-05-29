using System;
using ClosetGrower.GameObjects.Plants;
using ClosetGrower.GameObjects.Pots;
using ClosetGrower.GameObjects.Seeds;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Tools.Seeds
{
    public class LaughingBuddhaSeedTool : BaseTool
    {
        public LaughingBuddhaSeedTool(Game game)
            : base(game)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            //ToDo: Change this to a laughing buddha seed and plant.
            BasePot p = useWithThis as BasePot;
            p.PlantSeed(new PlantedSeedObject(this.Game, new BasePlant(this.Game)));           

        }
    }
}
