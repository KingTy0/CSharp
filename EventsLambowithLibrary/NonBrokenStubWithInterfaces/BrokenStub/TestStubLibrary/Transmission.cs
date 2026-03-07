using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectStub
{
    public class Transmission
    {
        public event EventHandler OnShiftUP;
        public event EventHandler OnShiftDOWN;

        public int HowManyGears
        {
            get;



            set;
            




        }
        protected void onShiftUp(object sender, EventArgs e)
        {
            if (this.currentGear + 1 > HowManyGears)
            {
                Console.WriteLine("Your in max gear");
                this.currentGear = HowManyGears;

            }
            else
            {
                this.currentGear++;
            }


        }
        public void ShiftUp()
        { 
            this.OnShiftUP.Invoke(this, EventArgs.Empty);   
                
        }

        protected void onShiftDown(object sender, EventArgs e)
        {
            if (this.currentGear - 1 < 0)
            {
                Console.WriteLine("Human your in neutral  ");
            }
            else 
            {
                this.currentGear--;
            
            
            }
        }
        public void ShiftDown()
        {
            this.OnShiftDOWN.Invoke(this, EventArgs.Empty);
        
        }

        //acting as max gears
        public Transmission()
        {
            this.currentGear = 0;
            this.OnShiftUP += onShiftUp;
            this.OnShiftDOWN += onShiftDown;
        }
        private int _currentGear;
        ////should start at 0 

        public int currentGear
        {
            get
            {
                return _currentGear;
            }
            set
            {
                _currentGear = value;
            }
        }
        //public void ShiftUP()
        //{

        //    if (this.currentGear + 1 > HowManyGears)
        //    {
        //        Console.WriteLine("Your in max gear");
        //        this.currentGear = HowManyGears;

        //    }
        //    else
        //    {
        //        this.currentGear++;
        //    }
        //}
        //public void ShiftDOWN()
        //{
        //    if (this.currentGear - 1 < 0)
        //    {
        //        Console.WriteLine("Human your in neutral  ");
        //    }
        //}
        public int SetGearCount(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Gear count cannot be negative.");
            }
            HowManyGears = count;
            return HowManyGears;
        }

        //public int SetGearCount(int count)
        //{

        //    count = HowManyGears;
        //    return HowManyGears;

        //}
    }
}
