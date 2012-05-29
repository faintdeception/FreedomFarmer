using System;
using System.ComponentModel;
using ClosetGrower.Enums;
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
                    if (this.Seed.Status == SeedStatus.UnGerminated)
                        this.Medium.Humdity -= this.Seed.MoistureAbsorbtionRate;
                }

                if (this.Plant != null)
                {
                    this.Medium.Humdity -= this.Plant.MoistureAbsorbtionRate;
                }
            }


        }

        internal void PlantSeed(PlantedSeedObject seed)
        {
            if (this.Plant != null)
                throw new Exception("There is already a plant in this pot.");

            if (this.Seed != null)
                throw new Exception("There is already a seed in this pot");

            if (this.Medium == null)
                throw new Exception("You need soil to plant a seed in this pot.");

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

        internal void AddGrowMedium(BaseMedium medium)
        {
            if(this.Medium != null)
                throw new Exception("There is already a medium in this pot");
            this.Medium = medium;
        }
    }
}
