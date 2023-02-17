using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    internal interface IFighterPlane
    {
        //private string primaryWeapon;

        IWeapon PrimaryWeapon { get; set; }
        IWeapon SecondaryWeapon { get; set; }


        void Display();
    }
}
