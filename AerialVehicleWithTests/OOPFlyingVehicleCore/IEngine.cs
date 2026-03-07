using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public interface IEngine : IAboutable
    {
     public  bool IsStarted { get; protected set; }

        void Start();
        void Stop();
    }
}