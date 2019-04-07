using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Program
    {
        static void Run()
        {
            Console.WriteLine("Commander: Let's move out to end this war");
            Humvee vic = new Humvee();
            Airsupport bomber = new Airsupport();
            Console.WriteLine("\n(Plane starts up on the flight line)");
            bomber.Starting("Plut plut plut");
            bomber.TakeOff();
            Console.WriteLine("\nPress any key to continue mission...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Humvee starts...");
            vic.Starting("Plat plat....vrooom");
            vic.Drive();
            vic.Transporting();
            Console.WriteLine("\nPress any key to continue mission...");
            Console.ReadKey();
            Console.Clear();

            vic.Moving();
            vic.Stopping("phut phut");
            vic.Disembark();
            Console.WriteLine("\nPress any key to continue mission...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Two hours later...");
            Sniper sgtHawkeye = new Sniper();
            sgtHawkeye.SoldierStatus("\nSgt Hawkeye: We have reached battle position Charlie");
            sgtHawkeye.FireWhenReady();
            sgtHawkeye.Permission();
            Console.WriteLine("\nPress any key to continue mission...");
            Console.ReadKey();
            Console.Clear();

            MachineGunner grunts = new MachineGunner();
            grunts.GiveMeATarget();
            grunts.SupportingFire();
            grunts.ReloadWeapon();
            Console.WriteLine("(Plane coming overhead)");
            Console.WriteLine("\nPress any key to continue mission...");
            Console.ReadKey();
            Console.Clear();

            bomber.AboveTarget();
            bomber.BombsGoingOff();
            bomber.Drive();
            Console.WriteLine("\nPress any key to continue mission...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Commander: Sniper Team Six you are cleared to engage");
            sgtHawkeye.MissionComplete();
            sgtHawkeye.ReloadWeapon();
            Console.WriteLine("\nEnd of Mission");

        }
        static void Main()
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
