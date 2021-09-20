using System;
using Interface.Interfaces;

namespace Interface.Duck
{
    public class MuteQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}