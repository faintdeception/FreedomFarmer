using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using ClosetGrower.GameObjects.Pots;

namespace ClosetGrower.GameObjects.Tools.Mediums
{
    class BaseMediumTool : BaseTool
    {
        public BaseMediumTool(Game game)
            : base(game)
        {

        }

        public override void Use(BaseGameObject useWithThis)
        {
            base.Use(useWithThis);

            BasePot Pot = useWithThis as BasePot;

            if (Pot == null)
            {
                throw (new Exception("You can only use grow mediums with pots"));
            }

            
        }
    }
}
