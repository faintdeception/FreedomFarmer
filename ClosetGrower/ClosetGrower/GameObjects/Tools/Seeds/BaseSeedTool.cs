using System;
using ClosetGrower.GameObjects.Pots;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Tools.Seeds
{
    public class BaseSeedTool : BaseTool
    {

        public BaseSeedTool(Game game)
            : base(game)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            if (useWithThis.GetType() != typeof(BasePot))
            {
                throw (new Exception("You can only use seeds with pots"));
            }
        }
    }
}
