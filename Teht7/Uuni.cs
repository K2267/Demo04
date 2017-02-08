using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    class Uuni : Kodinkone
    {
        public string OvenType { get; set; }
        public int OvenTemperature { get; set; }

        //constructor

        public Uuni(string Name, string Model, string ovenType, int ovenTemperature)
             : base(Name, Model)
        {
            OvenType = ovenType;
            OvenTemperature = ovenTemperature;
        }


        public override string ToString()
        {
            Console.WriteLine("Oven info");
            return base.ToString() + " OvenType:" + OvenType + " Ovens Temperature:" + OvenTemperature + "\n";
        }

    }
}
