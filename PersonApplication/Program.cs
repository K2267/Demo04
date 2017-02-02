using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Student object with parametric constuctor
            Teacher teacher = new Teacher("Kirsi", "Kernel", "D556");
            teacher.Age = 35;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "010-243051";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
