using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Fleet_of_Vehicles
{
    class Cars : FleetVehicles
    {
        private string sunRoof;
        // constructor
        public Cars(int yr, string clr, string mk, string md, string en, int d, string sR)
            : base(yr, clr, mk, md, en, d)
        {
            this.sunRoof = sR;
        }
        // getters
        //public int getYear() { return base.getYear(); }
        // display method
        public override string ToString()
        {
            return ($"{base.ToString()}{sunRoof}");
        }
    }

}
