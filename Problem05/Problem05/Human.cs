using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    internal class Human
    {
        private string _name;
        public string Name{
            get
            {
                return this._name.ToUpper();
            }
            set
            {
                this._name= value;
            } 
        }

        public string Display()
        {
            return _name;
        }
    }
}
