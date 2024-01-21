using System;

namespace Traffic_Lights
{
    internal partial class Program
    {
        abstract class AState
        {
            protected Context _context;

            public void SetContext(Context context)
            {
                _context = context;
            }

            public abstract void NextState();
        }
    }
}
