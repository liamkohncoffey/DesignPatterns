using System;
using Interface.Interfaces;

namespace Interface.Duck
{
    public class Quack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}