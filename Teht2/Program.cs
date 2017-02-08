using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin Amplifier = new Vahvistin();
            while (true)
            {
                Amplifier.Voice = Amplifier.Volume;
                //Amplifier.PrintData();
                Console.Write("Give a new floor number (1-5) > ");
                Amplifier.Volume = int.Parse(Console.ReadLine());
                Amplifier.PrintData();
            }
        }
    }
}