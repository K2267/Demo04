using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    class Mikro : Kodinkone
    {
        public string Power { get; set; }
        public bool Defrost { get; set; }

        //constructor

        public Mikro(string Name, string Model, bool defrost, string power)
             : base(Name, Model)
        {
            Power = power;
            Defrost = defrost;
        }



        public override string ToString()
        {
            Console.WriteLine("Mickro info");
            return base.ToString() + " Micros power: " + Power + " Defrost:" + Defrost + "\n";
        }

    }
}

