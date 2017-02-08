using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss nalle = new Boss();
            nalle.Name = "Nalle Whalröös";
            nalle.Salary = 100000;
            nalle.Profession = "TJ";
            nalle.Car = "Rolls Royce Phantom 6.2l V12 ";
            nalle.Bonus = 1000000;
            Console.WriteLine(nalle.ToString());

            Employee pekka = new Employee();
            pekka.Name = "Pekka Savolainen";
            pekka.Salary = 1209;
            pekka.Profession = "Varastotyöntekijä";
            Console.WriteLine(pekka.ToString());
            Console.ReadLine();
            
            pekka.Profession = "Varastovastaava/Varastotyöntekijä";
            pekka.Salary = 1300;
            Console.WriteLine("-'Pekan työnkuva muuttui, koska yritys päätti tehostaa toimintaa'-");
            Console.WriteLine(pekka.ToString());
            Console.ReadLine();

        }
    }
}
