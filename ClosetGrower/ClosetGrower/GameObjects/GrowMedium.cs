using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosetGrower.Enums;

namespace ClosetGrower.GameObjects
{
    class GrowMedium
    {
        public GrowMediumType Type { get; set; }
        public double Ph { get; set; }
        public double Humdity { get; set; }        
    }
}
