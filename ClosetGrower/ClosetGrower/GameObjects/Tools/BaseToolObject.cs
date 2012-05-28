using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Tools
{
    public class BaseToolObject : VisualGameObject
    {
        public BaseToolObject(Game game)
            : base(game)
        {

        }

        protected virtual void Use(BaseGameObject useWithThis)
        {

        }
    }
}
