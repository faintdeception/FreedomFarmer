using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosetGrower.GameObjects;

namespace ClosetGrower.Interfaces
{
    public interface IUseableTool
    {
        void Use(BaseGameObject useWithThis);
        
    }
}
