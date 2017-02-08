using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Boss : Employee
    {
        private string car;
        private int bonus;

        public string Car
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
            }
        }

        public int Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }

        // Methods
        public override string ToString()
        {
            Console.WriteLine("Boss:");
            return base.ToString() + " " + "Car: " + car + " " + "Bonus:" + " " + bonus;
        }

    }
}