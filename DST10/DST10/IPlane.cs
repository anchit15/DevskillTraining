using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST10
{
    internal interface IPlane
    {
         IWeapon PrimaryWeapon { get; set; }
         IWeapon SecondaryWeapon { get; set; }

    }
}
