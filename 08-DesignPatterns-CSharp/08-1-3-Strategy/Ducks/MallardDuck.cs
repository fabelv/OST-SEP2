namespace Strategy.Ducks
{
    using System;
    using Strategy.Quacks;
    using Strategy.Flys;


    public sealed class MallardDuck : Duck
    {
        public MallardDuck() : base (new Quack(), new NormalFly()) { }
        public override void Display() => Console.WriteLine("Green head, gray-brown body.");
    }
}