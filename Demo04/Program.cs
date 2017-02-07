using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator();
            while (true)
            {
                hissi.Kerros = hissi.Floor;
                hissi.PrintData();
                Console.Write("Give a new floor number (1-5) > ");
                hissi.Floor = int.Parse(Console.ReadLine());
                hissi.PrintData();
            }
        }
    }
}
