namespace Strategy.Ducks
{
    using System;
    using Strategy.Quacks;
    using Strategy.Flys;

    public sealed class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new Quack(), new NormalFly()) { }
        public override void Display() => Console.WriteLine("Red head, gray body.");
    }
}