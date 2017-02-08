using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Boat1 : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatNumber { get; set; }

        //constructor

        public Boat1(string Name, string Model, string boatType, int seatNumber)
             : base(Name,Model)
        {
            BoatType = boatType;
            SeatNumber = seatNumber;
        }


        public override string ToString()
        {
            Console.WriteLine("Boat info");
            return base.ToString() + " BoatType:" + BoatType + " SeatNumber:" + SeatNumber + "\n";
        }

    }
}
