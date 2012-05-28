using System;
using System.ComponentModel;
using ClosetGrower.GameObjects.Mediums;
using ClosetGrower.GameObjects.Plants;
using ClosetGrower.GameObjects.Seeds;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects.Pots
{
    class BasePot : VisualGameObject
    {
        public BaseMedium Medium { get; set; }

        [DefaultValue(0.000)]
        protected double MoistureAbsorbtionRate { get; set; }

        public BasePot(Game game)
            : base(game)
        {
            ClosetGrow cg = (ClosetGrow)game;
            cg.DayIncrimented += new DayIncrimentedEventHandler(Game_DayIncrimented);
        }

        void Game_DayIncrimented(object sender, EventArgs e)
        {
            if (this.Medium != null)
            {
                this.Medium.Humdity -= MoistureAbsorbtionRate;


                if (this.Seed != null)
                {
                    switch (this.Seed.Status)
                    {
                        default:
                            break;
                    }
                }
            }

            
        }

        public void PlantSeed(PlantedSeedObject seed)
        {
            this.Seed = seed;
            this.Seed.Germinated += new GerminatedEventHandler(Seed_Germinated);
        }

        void Seed_Germinated(object sender, SeedGerminatedEventArgs e)
        {
            this.Seed = null;
            this.Plant = e.Plant;
        }

        public PlantedSeedObject Seed { get; set; }
        public BasePlant Plant { get; set; }
    }
}
