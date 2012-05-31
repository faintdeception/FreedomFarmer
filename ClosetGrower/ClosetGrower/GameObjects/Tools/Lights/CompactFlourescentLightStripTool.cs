using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using ClosetGrower.Interfaces;

namespace ClosetGrower.GameObjects.Tools.Lights
{
    public class CompactFlourescentLightStripTool : BaseLightTool
    {
       public CompactFlourescentLightStripTool(Game game)
           : base(game)
       {
          
       }


       public override void Use(BaseGameObject useWithThis)
       {
           base.Use(useWithThis);
       }
    }
}
