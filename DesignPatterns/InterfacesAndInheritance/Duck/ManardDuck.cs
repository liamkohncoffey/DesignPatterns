using System;
using Interface.Implementation;

namespace Interface.Duck
{
    public class ManardDuck : AbstractDuck
    {
        public ManardDuck() : base(new FlyWithWings(), new Quack())
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("Red and while");
        }
    }
}