using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreedomFarmer.GameObjects;

namespace FreedomFarmer.Interfaces
{
    public interface IUseableTool
    {
        void Use(BaseGameObject useWithThis);
        
    }
}
