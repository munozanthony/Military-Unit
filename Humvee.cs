using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Humvee : Vehicle
    {
        public void Moving()
        {
            Console.WriteLine("Humvee: Vroooooommmmmm....plat plat.....vrrooommmmm!!!");
        }

        public void Transporting()
        {
            Console.WriteLine("Commander: Moving to phase line Abrams with four personnel");
        }

        public void Disembark()
        {
            Console.WriteLine("Commander: Move it soldiers...");
        }
        public override void Drive()
        {
            Console.WriteLine("Humvee: Motoring");
        }
    }
}
