using Interface.Interfaces;

namespace Interface.Duck
{
    public abstract class AbstractDuck
    {
        private readonly IFlyBehavior _flyBehavior;
        private readonly IQuackBehaviour _quackBehavior;

        protected AbstractDuck(IFlyBehavior flyBehavior, IQuackBehaviour quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.quack();
        }

        public void Swim()
        {
            System.Console.WriteLine("All ducks float, even decoys!");
        }
    }
}

 