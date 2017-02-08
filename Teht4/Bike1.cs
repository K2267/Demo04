using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Bike1 : Vehicle
    {
        public string GearName { get; set; }
        public bool Gear { get; set; }

        //constructor

        public Bike1(string Name, string Model, bool gear, string gearName)
             : base(Name,Model)
        {
            GearName = gearName;
            Gear = gear;
        }



        public override string ToString()
        {
            Console.WriteLine("Bike info");
            return base.ToString() + " GearWheels: " + Gear + " Gear name:" + GearName + "\n";
        }

    }
}

