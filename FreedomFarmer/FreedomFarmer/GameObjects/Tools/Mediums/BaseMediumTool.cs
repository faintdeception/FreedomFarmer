using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using FreedomFarmer.GameObjects.Pots;
using FreedomFarmer.Interfaces;

namespace FreedomFarmer.GameObjects.Tools.Mediums
{
    public class BaseMediumTool : BaseGameObject, IUseableTool
    {
        public BaseMediumTool(Game game)
            : base(game)
        {

        }

        /// <summary>
        /// The PH of the medium tool.
        /// </summary>
        public double PH { get; set; }

        public virtual void Use(BaseGameObject useWithThis)
        {
            
            if (!(useWithThis is BasePot))
            {
                throw (new Exception("You can only use grow mediums with pots"));
            }

            
        }
    }
}
