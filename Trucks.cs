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
        private string bedLength;

        public Trucks(string mk, string md, int yr, string co, string en, string bLi, string bLe)
            : base(mk, md, yr, co, en)
        {
            this.bedLiner = bLi;
            this.bedLength = bLe;
        }
    }
}
