using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat1 Boat = new Boat1("Buster", "S","Motorboat",2);
            Boat.ModelYear = 2010;
            Boat.Color = "Blue";
            Console.WriteLine(Boat.ToString());//Tulostaa boat datan

          
            Bike1 Bike = new Bike1("KTM", "Cyclocross", true, "Shimano");
            Bike.ModelYear = 2016;
            Bike.Color = "Orange/black";
            Console.WriteLine(Bike.ToString());//Tulostaa Bike datan
  
            
            Vehicle vehicle = new Vehicle("Skoda", "Octavia");
            vehicle.ModelYear = 2010;
            vehicle.Color = "White";
            Console.WriteLine(vehicle.ToString());//Tulostaa vehicle datan

            Console.ReadLine();
        }
    }
}
