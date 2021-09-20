using System;
using Interface.Interfaces;

namespace Interface.Implementation
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}