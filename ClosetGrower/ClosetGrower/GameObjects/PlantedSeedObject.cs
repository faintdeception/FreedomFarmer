using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using ClosetGrower.Enums;
using System.ComponentModel;

namespace ClosetGrower.GameObjects
{
    public delegate void GerminatedEventHandler(object sender, SeedGerminatedEventArgs e);

    class PlantedSeedObject : VisualGameObject
    {
        public PlantedSeedObject(Game game, PlantObject plant)
            : base(game)
        {
            this.Plant = plant;
            ClosetGrow cg = (ClosetGrow)game;
            cg.DayIncrimented += new DayIncrimentedEventHandler(Game_DayIncrimented);
        }

        public event GerminatedEventHandler Germinated;

        protected virtual void OnGerminated(SeedGerminatedEventArgs e)
        {
            if (Germinated != null)
                Germinated(this, e);                    
        }
    

        void Game_DayIncrimented(object sender, EventArgs e)
        {

            if (this.Age < this.MaxAge)
            {
                this.MoistureLevel += this.MoistureAbsorbtionRate;
                if (this.MoistureLevel > 1)
                {
                    this.OnGerminated(new SeedGerminatedEventArgs() { Plant = this.Plant });
                    this.Status = SeedStatus.Germinated;
                }
            }
            else
            {
                this.Status = SeedStatus.Dead;
            }
            this.Age++;

        }

        [DefaultValue(0.20)]
        public double MoistureAbsorbtionRate { get; set; }

        /// <summary>
        /// Base seeds are gonna be at a zero, basically the challenge with seeds is going to be getting their moisture 
        /// level to 100% before they get too old.
        /// 
        /// If you buy premium seeds then you're going to get a higher% than bag seeds.
        /// </summary>
        [DefaultValue(0.0)]
        public double MoistureLevel { get; set; }

        public int Age { get; private set; }

        public SeedStatus Status { get; private set; }

        /// <summary>
        /// The type of plant this seed is supposed to grow into.
        /// </summary>       
        public PlantObject Plant { get; set; }

        /// <summary>
        /// The max the seed can live before it's status changes to dead.  Even shitty seeds can take a really long time to germinate. 
        /// I'll say 1 year for now, but I'll consult with somone. Scratch that, it's a game, not a sim, 1 wk for shit seeds.
        /// </summary>
         
        [DefaultValue(7)]
        public int MaxAge { get; set; }

    }
}
