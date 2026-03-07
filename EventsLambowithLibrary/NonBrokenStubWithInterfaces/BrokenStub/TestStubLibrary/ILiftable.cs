using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStubLibrary
{
    public interface ILiftable
    {

        bool IsLifted { get; }

        public string ActivateLift(ILiftable Islifted);


    }
}