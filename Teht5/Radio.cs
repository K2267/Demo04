using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Radio
    {
        private double Frequency;
        private bool OnOff;
        private int Volume;
        private readonly int maxVolume = 9;//Rajoitus äänelle 
        private readonly int minVolume = 0;//
        private readonly double minFrequency = 2000.0;//Rajoitus taajuudelle
        private readonly double maxFrequency = 26000.0;//


        public bool Power
        {
            get
            {
                return OnOff;
            }
            set
            {
                OnOff = value;

                if (OnOff == false)
                    Console.WriteLine("Shutdown");
                else
                    Console.WriteLine("\n---------------");
                    Console.WriteLine("| Radio is ON |");
                    Console.WriteLine("---------------\n");
            }
        }

        public double frequency
        {
            get
            {
                return Frequency;
            }
            set
            {
                if (value <= maxFrequency)
                {
                    Frequency = value;
                    //Console.WriteLine("Channel freq. is: " + Frequency);
                }
                if (value < minFrequency)
                {
                    Console.WriteLine("Channel freq. cant be lower than 2000.0 ");
                    Frequency = minFrequency;
                }
                if (value > maxFrequency)
                {
                    Console.WriteLine("Channel freq. cant be higher than 26000.0");
                    Frequency = maxFrequency;
                }
            }
        }
        public int volume
        {
            get
            {
                return Volume;
            }
            set
            {
                if (value <= maxVolume)
                {
                    Volume = value;
                    //Console.WriteLine("Volume is: " + Volume);
                }
                if (value < minVolume)
                {
                    Console.WriteLine("Volume cant be lower than 0 ");
                    Volume = minVolume;
                }
                if (value > maxVolume)
                {
                    Console.WriteLine("Volume cant be higher than 9");
                    Volume = minVolume;
                }
            }
        }
        public void PrintFreq()
        {
            Console.WriteLine("Frequency is :" + Frequency);
        }
        public void PrintVolume()
        {
            Console.WriteLine("Volume is :" + Volume);
        }
    }
}
