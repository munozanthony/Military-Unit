using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Sniper : Soldier
    {
        public void FireWhenReady()
        {
            Console.WriteLine("Sgt Hawkeye: Target is acquired");
        }

        public void Permission()
        {
            Console.WriteLine("Sgt Hawkeye: Waiting for the green light");
        }

        public void MissionComplete()
        {
            Console.WriteLine("Sgt Hawkeye: Target Eliminated...Moving to extraction point Alpha");
        }

        public override void ReloadWeapon()
        {
            Console.WriteLine("Weapon: Click...clack");
        }
    }
}

