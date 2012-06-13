using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using FreedomFarmer.Interfaces;

namespace FreedomFarmer.GameObjects.Tools.Lights
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
            //ToDo: Make it so that lights can only be used with the cabinet, or grow slot, or whatever.
            
        }
    }
}
