
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicleCore
{
    public class JetEngine : Engine
    {



        public bool IsStarted { get; set; }


        public JetEngine() { }



        public virtual void Start()
        {
            IsStarted = true;
        }

        public virtual void Stop()
        {
            IsStarted = false;
        }

        public virtual string About()
        {
            string engineString = this.ToString() + " is not started.";
            if (this.IsStarted)
            {
                engineString = engineString.Replace("not ", "");
            }
            return engineString;
        }


    }





}
