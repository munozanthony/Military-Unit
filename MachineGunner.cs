using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class MachineGunner : Soldier
    {

        public void GiveMeATarget()
        {
            Console.WriteLine("Meanwhile....");
            Console.WriteLine("");
            Console.WriteLine("Saw Gunner: Point me in the right direction sarge...");
        }

        public void SupportingFire()
        {
            Console.WriteLine("Weapon: Sawwwwwwwww....2 o'clock, 4 enemy in the open....");
        }

        public override void ReloadWeapon()
        {
            Console.WriteLine("Saw Gunner: Reloading...I'm up");
        }

    }
}
