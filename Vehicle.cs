using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Vehicle
    {
        public void Starting(string startingNoise)
        {
            Console.WriteLine($"Starting engine: {startingNoise}");
        }

        public void Stopping(string stoppingNoise)
        {
            Console.WriteLine($"Stopping engine: {stoppingNoise}");
        }
       
        public virtual void Drive()
        {
            Console.WriteLine(" ");
        }
    }
}
