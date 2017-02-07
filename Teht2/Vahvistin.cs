using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Vahvistin
    {
        private readonly int MaxVolume = 0;
        private readonly int MinVolume = 100;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= MaxVolume) volume = value;
                // 
                if (value > 0) volume = value;
                // 
                if (value > MaxVolume)

                {
                    Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum : ");
                    volume = MaxVolume;
                }
                if (value < MinVolume)
                {
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : ");
                    volume = MinVolume;
                }
            }
        }

        public int Voice { get; set; }

        // constructor
        public Vahvistin()
        {
            Volume = 1;
            Voice = 1;
        }
        

        public void PrintData()
        {
            Console.WriteLine("Elevator is now in floor: " + Voice);
            //Console.WriteLine("Give a new floor number (1-5) > " + Floor);

        }
    }
}
