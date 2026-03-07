using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public class Helicopter : AerialVehicle,IHoverable
    {
        public Helicopter() : base(new ReciprocatingEngine())
        {
            this.MaxAltitude = 8000;
            this.howLong = 2;
        }
        public int howLong { get; set; }
        public Helicopter(ReciprocatingEngine engine) : base(engine) { }

        public string CanHover(IHoverable howlong)
        {
            { return $"this Vehicle can Hover for {this.howLong} Hours"; }
        }



    }
}
