using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Your Plane: ");
            Console.WriteLine("1. F-22");
            Console.WriteLine("2. Mig29");
            //Console.WriteLine("3. Mirage-5");
            int choicePlane = Convert.ToInt32(Console.ReadLine());

            IPlane plane = null;
            switch (choicePlane)
            {
                case 1:
                    plane = new F22();
                    break;
                case 2:
                    plane = new Mig29();
                    break;
                default:
                    break;
            }

            Console.WriteLine("You Have Selected: " +plane.GetType().Name);

            Console.WriteLine("Please Select Your Primary Weapon: ");
            Console.WriteLine("1. Bomb");
            Console.WriteLine("2. Gun");
            int primaryChoice = Convert.ToInt32(Console.ReadLine());

            switch (primaryChoice)
            {
                case 1:
                    plane.PrimaryWeapon = new Bomb();
                    break;
                case 2:
                    plane.PrimaryWeapon = new Gun();
                    break;

                default:
                    break;
            }
            Console.WriteLine("Please Select Your Secondary Weapon: ");
            Console.WriteLine("1. Bomb");
            Console.WriteLine("2. Gun");
            int secondaryChoice = Convert.ToInt32(Console.ReadLine());

            switch (secondaryChoice)
            {
                case 1:
                    plane.SecondaryWeapon = new Bomb();
                    break;
                case 2:
                    plane.SecondaryWeapon = new Gun();
                    break;

                default:
                    break;
            }

            while (true)
            {
                Console.WriteLine("Please Select Weapon Command: ");
                Console.WriteLine("1. Primary");
                Console.WriteLine("2. Secondary");
                Console.WriteLine("3. Exit");
                int weaponChoice = Convert.ToInt32(Console.ReadLine());

                switch (weaponChoice)
                {
                    case 1: 
                        plane.PrimaryWeapon.Fire();
                        break;
                    case 2: 
                        plane.SecondaryWeapon.Fire();
                        break;
                    default:
                        break;
                }
                if (weaponChoice==3)
                {
                    break;
                }

            }

            Console.WriteLine("=======================>Game Over");

            Console.ReadLine();
        }
    }
}
