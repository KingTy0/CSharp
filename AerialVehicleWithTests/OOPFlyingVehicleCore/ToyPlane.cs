using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public class ToyPlane : Airplane, OOPFlyingVehicleCore.IRemotecontrollable
    {
        bool isWoundUP
        {
            get;
            set;

        }

        public ToyPlane() : base(new RubberBandEngine())
        {
            this.MaxAltitude = 50;
            this.Engine = new RubberBandEngine();
            this.IsConnected = false;
        }

        public ToyPlane(RubberBandEngine engine) : base(engine) { }

        public override void StartEngine()
        {
            //throw new NotImplementedException();

            if (isWoundUP)
            {
                Engine.Start();


            }
        }

        public override string TakeOff()
        {
            //throw new NotImplementedException();
            //TODO Make this say sum 
            return null;
        }

        public void WindUp()
        {
            while (((ToyEngine)Engine).IsFullyWound == false)
            {
                this.Wind();
            }
        }

        public void Wind()
        {
            ((ToyEngine)Engine).Wind();
            isWoundUP = true;
        }

        public void UnWind()
        {
            //throw new NotImplementedException();
            // this is the opposite of Wind 
            if (((ToyEngine)Engine).NumWinds > 0)
            {
                ((ToyEngine)Engine).UnWind();
            }

        }
        public void UnWindCompletely()
        {
            //This is the opposite of WindUp
            //throw new NotImplementedException();
            if (((ToyEngine)Engine).NumWinds > 0)
            {
                while (((ToyEngine)Engine).NumWinds > 0)
                {
                    this.UnWind();
                }
                isWoundUP = false;

            }
        }

        protected string getWindUpString()
        {
            string woundUp = "It's not wound up.";
            if (isWoundUP) woundUp = woundUp.Replace("not ", "");
            return woundUp;
        }

        public override string About()
        {
            return base.About() + "\n" + this.getWindUpString();
        }


       


        public bool IsConnected { get; set; }


     

        public void ConnectController()
        {
            if (Engine.IsStarted == true)
            {
                this.IsConnected = true;
            }
            else
            {
                this.IsConnected = false;
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
