using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quacks
{
    internal class Quack : IQuackStrategie
    {
        void IQuackStrategie.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
