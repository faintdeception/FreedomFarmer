using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using ClosetGrower.GameObjects.Pots;
using ClosetGrower.Interfaces;

namespace ClosetGrower.GameObjects.Tools.Mediums
{
    public class BaseMediumTool : BaseGameObject, IUseableTool
    {
        public BaseMediumTool(Game game)
            : base(game)
        {

        }

        public virtual void Use(BaseGameObject useWithThis)
        {
            
            if (!(useWithThis is BasePot))
            {
                throw (new Exception("You can only use grow mediums with pots"));
            }

            
        }
    }
}
