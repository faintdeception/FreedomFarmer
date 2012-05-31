using Microsoft.Xna.Framework;
using ClosetGrower.Interfaces;

namespace ClosetGrower.GameObjects.Tools
{
    public class BaseTool : VisualGameObject, IUsableTool
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
