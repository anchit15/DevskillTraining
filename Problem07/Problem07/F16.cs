﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    internal class F16 : IFighterPlane
    {
        public IWeapon PrimaryWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IWeapon SecondaryWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.WriteLine("You Have Selected: F-16");
        }
    }
}
