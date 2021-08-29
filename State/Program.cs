using System;

namespace State
{
    // Concrete States implement various behaviors, associated with a state of the Context.
    public class TVONState : IState
    {
        public void doAction()
        {
            Console.WriteLine("TV is turned ON");
        }
    }

    public class TVSOFFState : IState
    {
        public void doAction()
        {
            Console.WriteLine("TV is turned OFF");
        }
    }

    class Program
    {
        static void Main()
        {
            TVContext context = new TVContext();
            IState onState = new TVONState();
            IState offState = new TVSOFFState();

            context.setState(onState);
            context.doAction();


            context.setState(offState);
            context.doAction();

            Console.ReadKey();
        }
    }
}
