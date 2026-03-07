using OOPFlyingVehicleCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public abstract class AerialVehicle : IFlyable
    {

        public IEngine Engine { get; protected set; }
        public bool IsFlying { get; protected set; }
        public int MaxAltitude { get; protected set; }
        public int CurrentAltitude { get; protected set; }
        public int DefaultFlightHight { get; protected set; }



        public AerialVehicle(IEngine engine)
        {
            Engine = engine;
        }
        public AerialVehicle()
        {
            this.Engine = new Engine();
            this.IsFlying = false;

        }

        public virtual void StartEngine()
        {
            Engine.Start();

        }

        public virtual void StopEngine()
        {
            Engine.Stop();

        }

        public virtual void FlyUp()
        {
            this.FlyUp(DefaultFlightHight);

        }

        public virtual void FlyUp(int HowManyFeet)
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

        public void FlyDown()
        {
            FlyDown(DefaultFlightHight);
        }

        public void FlyDown(int HowManyFeet)
        {
            if (HowManyFeet < 0) throw new InvalidOperationException("Can't FlyDown a negative amount");
            if (this.IsFlying)
            {
                if (this.CurrentAltitude - HowManyFeet >= 0)
                {
                    this.CurrentAltitude -= HowManyFeet;
                }

            }


        }

        public virtual string TakeOff()
        {
            if (Engine.IsStarted)
            {
                IsFlying = true;
                return $"{this.ToString()} is flying";
            }
            return $"{this.ToString()} can't fly it's engine is not started.";
        }

        /// <summary>
        /// Returns a string that describes if an engine is started
        /// </summary>
        /// <returns></returns>
        protected string getEngineStartedString()
        {
            return this.Engine.About();
        }

        public virtual string About()
        {
            string about = string.Format("This {0} has a max altitude of {1} ft. \nIt's current altitude is {2} ft. \n{3}",
                this.ToString(), this.MaxAltitude.ToString(), this.CurrentAltitude, this.getEngineStartedString());
            return about;
        }
    }
}