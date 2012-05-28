using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosetGrower.GameObjects
{
    public class SeedGerminatedEventArgs : EventArgs
    {
        public PlantObject Plant { get; set; }
    }

}
