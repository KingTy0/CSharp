using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFlyingVehicleCore
{
    public abstract class ToyEngine : Engine
    {
        public int NumWinds { get; set; }
        public int NumWindsFullyWound { get; set; }

        public bool IsFullyWound { 
            get { return NumWinds >= NumWindsFullyWound; } 
        }

        public ToyEngine()
        {
            this.NumWindsFullyWound = 20;
        }

        public override void Stop()
        {
            base.Stop();
        }
        public override void Start()
        {
            base.Start();
        }

        public override string About()
        {
            return base.About();
        }

        internal void Wind()
        {
            //throw new NotImplementedException();
            //this could be fullywound dont know yet 
            NumWinds++;
        }

        internal void UnWind()
        {
            //throw new NotImplementedException();
            NumWinds--;
        }
    }
}
