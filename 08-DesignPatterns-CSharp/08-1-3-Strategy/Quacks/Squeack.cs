using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quacks
{
    internal class Squeack : IQuackStrategie
    {
        public void Quack()
        {
            Console.WriteLine("Squeack");
        }
    }
}
