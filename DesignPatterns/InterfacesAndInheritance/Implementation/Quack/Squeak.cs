using System;
using Interface.Interfaces;

namespace Interface.Duck
{
    public class Squeak : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}