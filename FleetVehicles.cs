using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Fleet_of_Vehicles
{
    class FleetVehicles
    {
        private string make;
        private string model;
        private int year;
        private string color;
        private string engine;

        public FleetVehicles(string mk, string md, int yr, string co, string en)
        {
            this.make = mk;
            this.model = md;
            this.year = yr;
            this.color = co;
            this.engine = en;
        }

        public override string ToString()
        {
            return ToString();
        }
    }
}
