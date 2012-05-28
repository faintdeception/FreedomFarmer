using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ClosetGrower.GameObjects
{
    class Closet : BaseGameObject
    {
         public Closet(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }
        List<GrowSlot> _growSlots;
        public List<GrowSlot> GrowSlots
        {
            get
            {
                if (this._growSlots == null)
                    this._growSlots = new List<GrowSlot>();
                return this._growSlots;
            }
        }
    }
}
