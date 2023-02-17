using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Your Plane: ");
            Console.WriteLine("1. F-22");
            Console.WriteLine("2. F-16");
            Console.WriteLine("3. Mirage-5");
            int choice = Convert.ToInt32(Console.ReadLine());

            /*switch (choice)
            {
                case 1:
                    IFighterPlane fp = new F22();
                    break;
                case 2:
                    IFighterPlane fp = new F16();
                    break;
                case 3:
                    IFighterPlane fp = new Mirage5();
                    break;

            }*/
            IFighterPlane fp = null;
            fp = Choosing(choice);
            /*if(choice == 1 )
            {
                *//*IFighterPlane*//* fp = new F22();
            }
            else if(choice == 2 )
            {
                *//*IFighterPlane*//* fp = new F16();
            }
            else if(choice == 3 )
            {
                *//*IFighterPlane*//* fp = new Mirage5();
            }*/

            fp.Display();
            Console.WriteLine("========================================");

            Console.WriteLine("Please Select Your Primary Weapon: ");
            Console.WriteLine("1. Bomb");
            Console.WriteLine("2. Missile");
            Console.WriteLine("3. Machine Gun");
            int primaryChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Select Your Secondary Weapon: ");
            Console.WriteLine("1. Bomb");
            Console.WriteLine("2. Missile");
            Console.WriteLine("3. Machine Gun");
            int secondaryChoice = Convert.ToInt32(Console.ReadLine());

            IWeapon pw = null;
            IWeapon sw = null;

            if (primaryChoice == 1)
            {
                /*IFighterPlane*/
                pw = new Bomb();
                fp.PrimaryWeapon = pw;
            }
            else if (primaryChoice == 2)
            {
                /*IFighterPlane*/
                fp.PrimaryWeapon = new Missile();
            }
            else if (primaryChoice == 3)
            {
                /*IFighterPlane*/
                fp.PrimaryWeapon = new MachineGun();
            }
            
            if (secondaryChoice == 1)
            {
                /*IFighterPlane*/
                fp.SecondaryWeapon = new Bomb();
            }
            else if (secondaryChoice == 2)
            {
                /*IFighterPlane*/
                fp.SecondaryWeapon = new Missile();
            }
            else if (secondaryChoice == 3)
            {
                /*IFighterPlane*/
                fp.SecondaryWeapon = new MachineGun();
            }

            do
            {
                Console.WriteLine("Please Select Weapon Command: ");
                Console.WriteLine("1. Primary");
                Console.WriteLine("2. Secondary");
                Console.WriteLine("3. Exit");
                int command = Convert.ToInt32(Console.ReadLine());


                if (command == 1)
                {
                    /*IFighterPlane*/
                    fp.PrimaryWeapon.Action();
                }
                else if (command == 2)
                {
                    /*IFighterPlane*/
                    fp.SecondaryWeapon.Action();
                }
                else if (command == 3)
                {
                    /*IFighterPlane*/
                    break;
                }

            } while (true);



            Console.WriteLine("================================>Game Over");


            Console.ReadLine();


            

        }

        internal static IFighterPlane Choosing(int choice)
        {
            if (choice == 1)
            {
                /*IFighterPlane*/
                return new F22();
            }
            else if (choice == 2)
            {
                /*IFighterPlane*/
               return new F16();
            }
            else /*if (choice == 3)*/
            {
                /*IFighterPlane*/
                return new Mirage5();
            }
        }
    }
}
