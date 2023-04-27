namespace Strategy.Ducks
{
    using System;
    using Strategy.Quacks;
    using Strategy.Flys;


    public sealed class RubberDuck : Duck
    {
        public RubberDuck() : base(new Squeack(), new NonFly()) { }
        public override void Display() => Console.WriteLine("All yellow, made from rubber.");
    }
}