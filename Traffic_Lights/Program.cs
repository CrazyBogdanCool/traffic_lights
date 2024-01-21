using System;

namespace Traffic_Lights
{
    internal class Program
    {
        //Контекст (як я розумію це наший світлофор, що містить у собі стан який ми динамічно змінюємо від вхідного методу та теперішнього стану).
        class Context
        {
            private State _state = null;
            public State previousState;

            public Context(State initialState)
            {
                this.TransitionTo(initialState);
            }

            public void TransitionTo(State state)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Перемикаємо стан на: {state.GetType().Name}.");
                this.previousState = _state;
                this._state = state;
                this._state.SetContext(this);
            }

            public void NextState()
            {
                this._state.NextState();
            }
        }



        //Абстрактний стан для наслідування.
        abstract class State
        {
            protected Context _context;

            public void SetContext(Context context)
            {
                this._context = context;
            }

            public abstract void NextState();
        }



        //Перелік конкретних станів світлофора.
        class GreenState : State
        {
            public override void NextState()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Зелений Колір");
                this._context.TransitionTo(new YellowState());
            }
        }

        class RedState : State
        {
            public override void NextState()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Зелений Колір");
                this._context.TransitionTo(new YellowState());
            }
        }

        class YellowState : State
        {
            public override void NextState()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Жовтий колір");
                if (this._context.previousState is GreenState)
                {
                    this._context.TransitionTo(new RedState());
                }
                else
                {
                    this._context.TransitionTo(new GreenState());
                }
            }
        }


        //Робота з світлофором.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var context = new Context(new GreenState());

            for (int i = 0; i < 10; i++)
            {
                context.NextState();
            }

            Console.ReadKey();
        }
    }
}