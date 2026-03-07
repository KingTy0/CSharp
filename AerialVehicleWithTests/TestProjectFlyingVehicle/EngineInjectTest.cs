using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

using OOPFlyingVehicleCore;
using OOPFlyingVehicleCore.Ninject;

namespace TestProjectFlyingVehicle
{
    [TestClass ]
    public class EngineInjectTest
    {


        IKernel kernel;

        public EngineInjectTest()
        {
            kernel = new StandardKernel(new EngineModelL());
        }


        [TestMethod]
        public void EngineTests()
        {

            Engine engine;
            AerialVehicle vehicle;


            engine = kernel.Get<Engine>();


            Assert.IsInstanceOfType(engine, typeof(Engine));


            vehicle = kernel.Get<Airplane>();

            Assert.IsInstanceOfType(vehicle.Engine, typeof(JetEngine));

            vehicle = kernel.Get<Helicopter>();

            Assert.IsInstanceOfType(vehicle.Engine, typeof(ReciprocatingEngine));

            vehicle = kernel.Get<Drone>();

            Assert.IsInstanceOfType(vehicle.Engine, typeof(UAVEngine));

            vehicle = kernel.Get<ToyPlane>();

            Assert.IsInstanceOfType(vehicle.Engine, typeof(RubberBandEngine));


        }


















    }
}
