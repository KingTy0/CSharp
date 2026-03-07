using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public interface IHoverable : IFlyable
    {
       //string CanHover { get; }
       int howLong { get; }
        public string CanHover(IHoverable howlong);

    }
}