using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public class Airplane : AerialVehicle
    {

        public Airplane() : base(new JetEngine())
        {
            this.MaxAltitude = 41000;
            this.CurrentAltitude = 0;
            this.DefaultFlightHight = 1000;

        }

        public Airplane(IEngine engine) : base(engine) { }
    }
}
