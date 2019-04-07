using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Soldier
    {
       
        public void SoldierStatus(string status)
        {
            Console.WriteLine($"\nCommander: What is your status...\n {status}");
        }
         public void FiringWeapon(string fireWeapon)
        {
            Console.WriteLine($"Firing weapon: {fireWeapon}");
        }
         public virtual void ReloadWeapon()
        {
            Console.WriteLine(" ");
        }
    }
}
