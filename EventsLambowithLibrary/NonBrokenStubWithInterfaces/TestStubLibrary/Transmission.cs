using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectStub
{
    public class Transmission
    {
        public int HowManyGears
        {
            get;



            set;
            




        }
        //acting as max gears
        public Transmission()
        {


        }
        private int _currentGear;
        //should start at 0 

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
        public void ShiftUP()
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
        public void ShiftDOWN()
        {
            if (this.currentGear - 1 < 0)
            {
                Console.WriteLine("Human your in neutral  ");
            }
        }
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
