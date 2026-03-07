using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStubLibrary
{
    public interface ILaunchable
    {


        int CurrentSpeed { get; }

        int TopSpeed { get; }

        double ZeroToSixty {  get; }


    }
}