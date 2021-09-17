using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamientoClases
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEmpleado emple1 = new ClsEmpleado("luis", 33, 120.9f);

            Console.WriteLine("su nomnre es " + emple1.Nombre);// get

            emple1.Nombre = "Steven Universe";//set

            //cambiar la edad, leer la edad y el sueldo diario

            Console.WriteLine("dias trababajos?");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su sueldo va a ser: " + emple1.CalculaSueldo(dias));



        }
    }
}
