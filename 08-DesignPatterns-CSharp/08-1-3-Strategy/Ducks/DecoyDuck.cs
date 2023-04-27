namespace Strategy.Ducks
{
    using System;
    using Strategy.Quacks;
    using Strategy.Flys;

    public sealed class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new RoboticQuack(), new RoboticFly()) { }

        public override void Display()
        {
            Console.WriteLine("Looks like mallard duck, but made from metal.");
        }
    }
}