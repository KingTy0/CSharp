using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPFlyingVehicleCore;

namespace OOPFlyingVehicleCore.Ninject
{
    public class EngineModelL : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ToyEngine>().To<RubberBandEngine>();
            this.Bind<IEngine>().To<UAVEngine>().WhenInjectedInto<Drone>();
            this.Bind<IEngine>().To<RubberBandEngine>().WhenInjectedInto<ToyPlane>();
            this.Bind<IEngine>().To<ReciprocatingEngine>().WhenInjectedInto<Helicopter>();
            this.Bind<IEngine>().To<JetEngine>().WhenInjectedInto<Airplane>();



        }
    }
}
