using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST10
{
    internal class F22 : IPlane
    {
        public IWeapon PrimaryWeapon { get; set; }
        public IWeapon SecondaryWeapon { get; set; }

    }
}
