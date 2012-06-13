using Microsoft.Xna.Framework;
using FreedomFarmer.Interfaces;

namespace FreedomFarmer.GameObjects.Tools
{
    public class BaseTool : VisualGameObject, IUseableTool
    {
        public BaseTool(Game game)
            : base(game)
        {

        }

        //public virtual void Use(BaseGameObject useWithThis)
        //{

        //}

        public virtual void Use(BaseGameObject useWithThis)
        {
            throw new System.NotImplementedException();
        }
    }
}
