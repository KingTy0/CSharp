using Microsoft.VisualStudio.TestTools.UnitTesting;

using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectFlyingVehicle
{
    [TestClass]
    public class InterfaceTests 
    {
        [TestMethod]
        public void IRemoteControllableTest() 
        {
            //ACT
            ToyPlane tp = new ToyPlane();
            Drone de = new Drone();
            

            //Arrange
            Assert.IsInstanceOfType(tp, typeof(IRemotecontrollable));
            Assert.IsInstanceOfType(de, typeof(IRemotecontrollable));

           
        
        
        }
        [TestMethod]
        public void IHoverableTest()
        { 
            //ACT
            Helicopter he = new Helicopter();
            Drone de = new Drone();


            //Arrange
            Assert.IsInstanceOfType(he, typeof(IHoverable));
            Assert.IsInstanceOfType (de, typeof(IHoverable));
        
        
        
        
        }
            [TestMethod]
        public void IFlyableTest()
        { 
            //ACT
            Airplane ap = new Airplane();
            Drone de = new Drone();
            Helicopter he = new Helicopter();
            ToyPlane tp = new ToyPlane();

            //Arrange
            Assert.IsInstanceOfType(ap, typeof(IFlyable));
            Assert.IsInstanceOfType(he,typeof(IFlyable));
            Assert.IsInstanceOfType(tp,typeof(IFlyable));
            Assert.IsInstanceOfType(de ,typeof(IFlyable));
        
        
        
        
        
        }




    }
}
