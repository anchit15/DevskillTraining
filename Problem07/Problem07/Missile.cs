using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    internal class Missile : IWeapon
    {
        public void Action()
        {
            Console.WriteLine("================================>Firing Missile");
        }

        
    }
}
