using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST10
{
    internal class Bomb : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Dropping Bomb");
        }
    }
}
