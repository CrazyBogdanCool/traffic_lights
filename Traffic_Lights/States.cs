using System;

namespace Traffic_Lights
{
    internal partial class Program
    {
        class GreenState : AState
        {
            public override void NextState()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Зелений Колір");
                _context.TransitionTo(new YellowState());
            }
        }

        class RedState : AState
        {
            public override void NextState()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Зелений Колір");
                _context.TransitionTo(new YellowState());
            }
        }

        class YellowState : AState
        {
            public override void NextState()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Жовтий колір");
                if (_context.previousState is GreenState)
                {
                    _context.TransitionTo(new RedState());
                }
                else
                {
                    _context.TransitionTo(new GreenState());
                }
            }
        }
    }
}
