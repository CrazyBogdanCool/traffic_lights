using System;

namespace Traffic_Lights
{
    internal partial class Program
    {
        class Context
        {
            private AState _state = null;
            public AState previousState;

            public Context(AState initialState)
            {
                TransitionTo(initialState);
            }

            public void TransitionTo(AState state)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Перемикаємо стан на: {state.GetType().Name}.");
                previousState = _state;
                _state = state;
                _state.SetContext(this);
            }

            public void NextState()
            {
                _state.NextState();
            }
        }
    }
}