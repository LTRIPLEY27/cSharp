using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, age;
            string name;
            float sould;

            

            Console.WriteLine("indique su nombre");
            name = Console.ReadLine();

            //emple.Nombre = name;

            Console.WriteLine("indique su edad");
            age = Convert.ToInt32(Console.ReadLine());

            //emple.Edad = age;

            Console.WriteLine("indique su saldo");
            sould = (float)Convert.ToDouble(Console.ReadLine());

            //emple.SueldoDiario = sould;

            ClsEmpleados emple = new ClsEmpleados(name, sould, age);

            ClsEmpleados emple1 = new ClsEmpleados("CAMI", 33);

            Console.WriteLine(emple1.SueldoDiario);

            Console.WriteLine("indique el numero de dias trabajados?");
            dias = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"El sueldo segun sus dias es {emple.CalculaSueldo(dias)}");


            Console.ReadKey();
        }
    }
}
