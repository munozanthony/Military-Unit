using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Airsupport : Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Pilot: Taking off");
        }

        public void AboveTarget()
        {
            Console.WriteLine("Pilot: Dropping payload in...3,2,1");
        }

        public void BombsGoingOff()
        {
            Console.WriteLine("BOOOOOOOMMMMMMM!!!!");
        }

        public override void Drive()
        {
            Console.WriteLine("Pilot: Flying to base");
        }
    }
}
