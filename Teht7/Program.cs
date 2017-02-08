using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            Uuni oven = new Uuni("UPO", "CM7500", "Stove", 250);
            oven.ModelYear = 2017;
            oven.Color = "White";
            Console.WriteLine(oven.ToString());//Tulostaa uunin datan


            Mikro micro = new Mikro("Samsung", "ZZB300", true, "1000W");
            micro.ModelYear = 2016;
            micro.Color = "Steel";
            Console.WriteLine(micro.ToString());//Tulostaa mikron datan


            Kodinkone pesukone = new Kodinkone("LG", "F14AW");
            pesukone.ModelYear = 2017;
            pesukone.Color = "White";
            Console.WriteLine(pesukone.ToString());//Tulostaa kodinkoneen datan

            Console.ReadLine();
        }
    }
}
