using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using ClosetGrower.Interfaces;

namespace ClosetGrower.GameObjects.Tools.Lights
{
    public class BaseLightTool : BaseGameObject, IUseableTool
    {
        public BaseLightTool(Game game)
            : base(game)
        {

        }

        public double Watts { get; protected internal set; }

        public double Lumens { get; protected internal set; }

        public double powerUsage { get; protected internal set; }


        public virtual void Use(BaseGameObject useWithThis)
        {
            throw new NotImplementedException();
        }
    }
}
