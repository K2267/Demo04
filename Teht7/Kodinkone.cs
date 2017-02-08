using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    class Kodinkone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }




        public Kodinkone(string name, string model)
        {
            Name = name;
            Model = model;
        }

        
        public void VehicleMethod()
        {
            Console.WriteLine("This method belongs to House Electronics!");
        }

        // return vehicle data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            Console.WriteLine("Home appliance info");
            return "- Name:" + Name + " Model:" + Model + " ModelYear:" + ModelYear + " Color:" + Color + "\n";
        }
    }
}