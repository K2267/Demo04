using System;
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



        // constructor takes person firstname and lastname as a parameter
        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }

        // just one method what Person can do
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            Console.WriteLine("Vehicle info");
            return "- Name:" + Name + " Model:" + Model + " ModelYear:" + ModelYear + " Color:" + Color + "\n";
        }
    }
}