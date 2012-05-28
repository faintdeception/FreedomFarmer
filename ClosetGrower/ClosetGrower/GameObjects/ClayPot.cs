using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects
{
    /// <summary>
    /// Clay Pots absorb a litte bit of moisture out of the grow medium every day, and then evaporate it into the air.
    /// </summary>
    class ClayPot : Pot
    {

        //const double MOISTUREABSORBTIONRATE = .005;

        public ClayPot(Game game)
            : base(game)
        {
            this.MoistureAbsorbtionRate = 0.005;    
        }
       
    }
}
