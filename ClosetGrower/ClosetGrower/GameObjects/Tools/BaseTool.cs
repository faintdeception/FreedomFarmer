using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Tools
{
    public class BaseTool : VisualGameObject
    {
        public BaseTool(Game game)
            : base(game)
        {

        }

        public virtual void Use(BaseGameObject useWithThis)
        {

        }
    }
}
