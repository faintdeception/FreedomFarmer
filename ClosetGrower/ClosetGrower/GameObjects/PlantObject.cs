using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.ComponentModel;

namespace ClosetGrower.GameObjects
{
    public class PlantObject : VisualGameObject
    {
        public PlantObject(Game game)
            : base(game)
        {
            ClosetGrow cg = (ClosetGrow)game;
            cg.DayIncrimented += new DayIncrimentedEventHandler(Game_DayIncrimented);
        }
        
        /// <summary>
        /// How much water does the plant absorb every day?  20%
        /// </summary>
        [DefaultValue(0.20)]
        protected double MoistureAbsorbtionRate { get; set; }

        void Game_DayIncrimented(object sender, EventArgs e)
        {
            //The logic for plants is probably going to be pretty complex, but basically it's going to feed, and then it's going to grow.
            //this.

            
        }
    }
}
