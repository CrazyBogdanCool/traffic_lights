using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLight
{
    internal class TrafficLight : Colors
    {
        public void TurnOn()
        {
            Red(10000);
            RedYellow(2000, 2);
            Grean(10000, 0);
            Grean(1000, 4);
            Yellow(2000);
            TurnOn();
        }
    }
}
