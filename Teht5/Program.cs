using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Power = true;
            while (radio.Power == true) 
            {
                Console.Write("Give a freq > ");//Taajuuden testaamiseen
                radio.frequency = int.Parse(Console.ReadLine());
                radio.PrintFreq();
                Console.Write("How loud you want to listen radio? > ");
                radio.volume = int.Parse(Console.ReadLine());
                radio.PrintVolume();
            }
            

        }
    }
}
