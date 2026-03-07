using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public interface IRemotecontrollable
    {
        bool IsConnected { get; }

      public  string  ConnectedtoController(IRemotecontrollable IsConnected);

        void ConnectController();
        
    }
}