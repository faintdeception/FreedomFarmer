using System;
using ClosetGrower.GameObjects.Plants;

namespace ClosetGrower.GameObjects
{
    public class SeedGerminatedEventArgs : EventArgs
    {
        public BasePlant Plant { get; set; }
    }

}
