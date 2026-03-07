using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectStub
{
    public class Lamborghini : SuperCars
    {

        public Lamborghini() 
        {
          
            this.Name = "Aventador SV";
            this.TopSpeed = 218;
           transmission.SetGearCount(7);
            SetEngineName("V12");
            transmission.ShiftUP();
        }
    }
}
