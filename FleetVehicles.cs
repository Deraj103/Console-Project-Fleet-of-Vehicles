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
        private int doors;
        // constructor
        public FleetVehicles(int yr, string clr, string mk, string md, string en, int d)
        {
            this.make = mk;
            this.model = md;
            this.year = yr;
            this.color = clr;
            this.engine = en;
            this.doors = d;
        }
        // getters
        public int getYear() { return year; }
        // display method
        public override string ToString()
        {
            return ($"{year} {color} {make} {model}, {engine} engine, {doors} doors, ");
        }
    }
}
