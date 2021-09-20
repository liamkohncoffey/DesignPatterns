using System;
using Interface.Interfaces;

namespace Interface.Implementation
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}