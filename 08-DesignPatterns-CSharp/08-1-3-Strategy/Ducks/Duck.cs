// ReSharper disable VirtualMemberNeverOverridden.Global

namespace Strategy.Ducks
{
    using System;
    using Strategy.Quacks;
    using Strategy.Flys;

    public abstract class Duck
    {
        private readonly IQuackStrategie _quack;
        private readonly IFlyStrategie _fly;
        public Duck(IQuackStrategie quack, IFlyStrategie fly)
        {
            _quack = quack;
            _fly = fly;
        }
        public virtual void Quack() => _quack.Quack();

        public virtual void Swim() => Console.WriteLine("Swimming.");

        public virtual void Fly() => _fly.Fly();

        public abstract void Display();
    }
}
