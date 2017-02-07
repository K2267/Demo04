using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Elevator
    {
        private readonly int HighestFloor = 5;
        private readonly int LowestFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= HighestFloor) floor = value;
                // 
                if (value > 0) floor = value;
                // 
                if (value > HighestFloor)
                
                {
                    Console.WriteLine("The higest floor is 5th floor! >> ");
                    floor = HighestFloor;
                }
                if (value < LowestFloor)
                {
                    Console.WriteLine("Elevator cannot go there!");
                    floor = LowestFloor;
                }
            }
        }

        public int Kerros { get; set; }

        // constructor
        public Elevator()
        {
            Floor = 1;
            Kerros = 1;
        }


        public void PrintData()
        {
            Console.WriteLine("Elevator is now in floor: " + Kerros);
            //Console.WriteLine("Give a new floor number (1-5) > " + Floor);

        }
    }
}

