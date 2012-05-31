using System;
using ClosetGrower.GameObjects.Pots;
using Microsoft.Xna.Framework;
using ClosetGrower.Interfaces;

namespace ClosetGrower.GameObjects.Tools.Seeds
{
    public class BaseSeedTool : BaseGameObject, IUseableTool
    {

        public BaseSeedTool(Game game)
            : base(game)
        {

        }

        public virtual void Use(BaseGameObject useWithThis)
        {
          
            if (!(useWithThis is BasePot))
            {
                throw (new Exception("You can only use seeds with pots"));
            }
        }
    }
}
