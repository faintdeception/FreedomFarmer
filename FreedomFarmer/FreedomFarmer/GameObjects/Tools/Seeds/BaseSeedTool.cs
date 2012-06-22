using System;
using FreedomFarmer.GameObjects.Pots;
using Microsoft.Xna.Framework;
using FreedomFarmer.Interfaces;

namespace FreedomFarmer.GameObjects.Tools.Seeds
{
    public class BaseSeedTool : BaseGameObject, IUseableTool
    {

        public BaseSeedTool(Game game, Vector2 start)
            : base(game, start)
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
