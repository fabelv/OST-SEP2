using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Flys
{
    internal class RoboticFly : IFlyStrategie
    {
        public void Fly()
        {
            Console.WriteLine("Jetengine noise");
        }
    }
}
