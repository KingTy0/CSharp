using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectStub
{
    public class Ferrari : SuperCars
    {
        public Ferrari() 
        {

            this.Name = "488 GTB Ferrari";
            this.TopSpeed = 205;
            transmission.SetGearCount(7);
            SetEngineName("V8");
            ZeroToSixty = 3.0;
        
        }    
    }
}
