using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStubLibrary;

namespace EventsLamborghini.ViewModels
{
    public class SuperCarViewModel : BaseViewModel
    {

        ILaunchable launchable;

        public int TopSpeed
        {
            get
            {

                return launchable.TopSpeed;

            }

        }

        public double ZeroToSixty
        {
            get
            {
                return launchable.ZeroToSixty;
            }

        }
        public SuperCarViewModel(ILaunchable launchable)
        {
            this.launchable = launchable;



        }
    }
}
