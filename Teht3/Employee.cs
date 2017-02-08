using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Employee
    {
        private string name;
        private string profession;
        private int salary;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                profession = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        // Methods
        public override string ToString()
        {
            Console.WriteLine("Employee:");
            return "- Name: " + name + " " + "Profession: " + profession + " " + "Salary: " + salary + " ";
        }
    }

}