using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public class Drone : AerialVehicle, IHoverable, IRemotecontrollable
    {

        public Drone() : base(new UAVEngine())
        {
            this.MaxAltitude = 500;
            this.IsConnected = false;
            this.howLong = 5;
        }
        public Drone(UAVEngine engine) : base(engine) { }

        public int howLong {  get; set; }


        public bool IsConnected { get; set; }


        public string CanHover(IHoverable howlong)
        {
            { return $"this Vehicle can Hover for {this.howLong} minutes"; }
        }

        public void ConnectController()
        {
            if (Engine.IsStarted == true)
            {
                this.IsConnected = true;
            }
            else 
            {
                this.IsConnected= false;
                //
            
            }
        }

        public string ConnectedtoController(IRemotecontrollable IsConnected)
        {
            throw new NotImplementedException();
        }

        public override void FlyUp(int HowManyFeet)
        {
            //adding check to ensure that the controller is connected before the drone can fly
            if (IsConnected)
            {
                //If HowMany feet is nagtive trow invaid operation exception
                if (HowManyFeet < 0) throw new InvalidOperationException("Can't FlyUp a negative amount");
                if (this.IsFlying)
                {
                    if (this.CurrentAltitude + HowManyFeet <= this.MaxAltitude)
                    {
                        this.CurrentAltitude += HowManyFeet;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Make sure the Controller is connected first before you attempt to fly");
            }
        }

        public override void FlyUp()
        {
            //throw new NotImplementedException();
            this.FlyUp(DefaultFlightHight);
        }

        //string CanHover { get => default(string); }

        //public string CanHover(IHoverable hoverable) { return $"this Vehicle can Hover for {this.howLong}"; }

    }
}
