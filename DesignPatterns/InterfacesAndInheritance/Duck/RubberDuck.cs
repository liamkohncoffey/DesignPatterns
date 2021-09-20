using System;
using Interface.Implementation;

namespace Interface.Duck
{
    public class RubberDuck : AbstractDuck
    {
        public RubberDuck() : base(new FlyNoWay(), new Squeak())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Yellow");
        }
    }
}