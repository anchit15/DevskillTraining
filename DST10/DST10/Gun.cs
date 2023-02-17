using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST10
{
    internal class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Shooting Gun");
        }
    }
}
