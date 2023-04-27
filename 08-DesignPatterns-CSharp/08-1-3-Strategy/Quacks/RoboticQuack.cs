using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quacks
{
    internal class RoboticQuack : IQuackStrategie
    {
        public void Quack()
        {
            Console.WriteLine("beep boop ");
        }
    }
}
