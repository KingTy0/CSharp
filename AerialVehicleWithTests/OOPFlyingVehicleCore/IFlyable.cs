using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public interface IFlyable
    {
        int CurrentAltitude { get; }
        int MaxAltitude { get; }

        void FlyUp(int HowManyFeet);
        void FlyUp();
        void FlyDown();
        void FlyDown(int HowManyFeet);
    }
}