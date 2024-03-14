using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Fleet_of_Vehicles
{
    class Trucks : FleetVehicles
    {
        private string bedLiner;
        private int bedLength;
        // constructor
        public Trucks(int yr, string clr, string mk, string md, string en, int d, int bLe, string bLi)
            : base(yr, clr, mk, md, en, d)
        {
            this.bedLiner = bLi;
            this.bedLength = bLe;
        }
        // getters
        //public int getYear() { return base.getYear(); }
        // display method
        public override string ToString()
        {
            return ($"{base.ToString()}bed length {bedLength}, {bedLiner}");
        }
    }
}
