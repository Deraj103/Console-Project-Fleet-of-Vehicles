﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Fleet_of_Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reply = "";
            string make = "";
            string model = "";
            int year = 0;
            string color = "";
            string engine = "";
            string sunRoof = "";
            int doors = 0;
            string bedLiner = "";
            int bedLength = 0;

            WriteLine("Chapter 12 Console Project Fleet of Vehicles by Jared Tims\n");
            // class instantiation
            //Cars c = new Cars(year, color, make, model, engine, doors, sunRoof);
            //Trucks t = new Trucks(year, color, make, model, engine, doors, bedLength, bedLiner);
            // arrayList instantiation
            ArrayList vehicleArray = new ArrayList();
            // hardcoded vehicles
            vehicleArray.Add(new Cars(2015, "gray", "Honda", "Accord", "hybrid", 4, "sunroof"));
            vehicleArray.Add(new Trucks(2014, "black", "Ford", "F150", "diesel", 2, 70, "no bed liner"));
            vehicleArray.Add(new Cars(2018, "white", "Toyoya", "Corolla", "electric", 4, "sunroof"));
            vehicleArray.Add(new Trucks(2019, "silver", "Dodge", "RAM", "gas", 4, 76, "bed liner"));
            vehicleArray.Add(new Cars(2017, "red", "Ford", "Mustang", "gas", 2, "no sunroof"));
            vehicleArray.Add(new Trucks(2018, "blue", "Nissan", "Titan", "gas", 2, 68, "bed liner"));

            foreach (FleetVehicles vehicle in vehicleArray)
            {
                WriteLine($"{vehicle.ToString()}");
            }

            do
            {
                Write("\nWhat type of vehicle do you want to see, (c)Car or (t)Truck or (d)Done? ");
                reply = ReadLine();

                if (reply == "c")
                {
                    foreach (FleetVehicles vehicle in vehicleArray)
                    {
                        if (vehicle is Cars)
                        {
                            WriteLine($"{vehicle.ToString()}");
                        }
                    }
                }
                else if (reply == "t")
                {
                    foreach (FleetVehicles vehicle in vehicleArray)
                    {
                        if (vehicle is Trucks)
                        {
                            WriteLine($"{vehicle.ToString()}");
                        }
                    }
                }
                else if (reply == "d")
                {
                    Write("Which year vehicle? ");
                    year = int.Parse(ReadLine());
                    findIt(vehicleArray, year);
                }
                else
                {
                    WriteLine("That is an invalid option, please try providing a differen answer.");
                }

            } while (reply != "d");

            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
        // helper method to find the customer from the arrayList
        public static int findIt(ArrayList vehicleArray, int year)
        {
            for (int i = 0; i < vehicleArray.Count; i++)
            {
                FleetVehicles entry = (FleetVehicles)vehicleArray[i];
                if (year.Equals(entry.getYear()))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
