using System;
using FreedomFarmer.GameObjects.Plants;

namespace FreedomFarmer.GameObjects
{
    public class SeedGerminatedEventArgs : EventArgs
    {
        public BasePlant Plant { get; set; }
    }

}
