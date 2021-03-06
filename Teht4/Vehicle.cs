﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }



        
        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }

        // just one method what Vehicle can do
        public void VehicleMethod()
        {
            Console.WriteLine("This method belongs to Vehicle!");
        }

        // return vehicle data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            Console.WriteLine("Vehicle info");
            return "- Name:" + Name + " Model:" + Model + " ModelYear:" + ModelYear + " Color:" + Color + "\n";
        }
    }
}