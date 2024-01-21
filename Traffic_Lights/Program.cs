using System;

namespace Traffic_Lights
{
    internal partial class Program
    {
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