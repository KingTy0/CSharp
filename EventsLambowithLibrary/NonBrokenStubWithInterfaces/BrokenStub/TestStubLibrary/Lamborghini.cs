using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectStub
{
    public class Lamborghini : SuperCars
    {
        //public event EventHandler OnShiftupLambo;
        //public event EventHandler OnShiftDownLambo;
        public Lamborghini() 
        {
          
            this.Name = "Aventador SV";
            this.TopSpeed = 218;
           this.transmission.SetGearCount(7);
            SetEngineName("V12");
            this.ZeroToSixty = 2.5;
            //this.OnShiftupLambo += onShiftupLambo;
            //this.OnShiftDownLambo += onShiftDownLambo;
        }

        #region FailedExperiment
        //protected void onShiftupLambo(object sender, EventArgs e)
        //{
        //    this.transmission.ShiftUP();
        //    //this.transmission.currentGear++;

        //}


        //public void ShiftupLambo() 
        //{
        
        //    this.OnShiftupLambo.Invoke(this, EventArgs.Empty);
        
        //}



        //protected void onShiftDownLambo(object sender, EventArgs e)
        //{
        //    this.transmission.ShiftDOWN();
        //    //this.transmission.currentGear++;

        //}


        //public void ShiftDownLambo()
        //{

        //    this.OnShiftDownLambo.Invoke(this, EventArgs.Empty);

        //}

        #endregion



    }
}
