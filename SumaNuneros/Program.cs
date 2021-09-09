using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNuneros
{
    /*Definir un número entero 24
Definir un número float 8.7458
Multiplicar el entero por 4
Salida:
Dar la suma de las partes enteras de los dos números
Dar la suma de los dos números con sus decimales*/
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 24;
            float num2 = 8.7458f;

            Console.WriteLine($"El resultado del primer parametro por 4 es : {num1 * 4}");

            Console.WriteLine($"El resultado del de la suma es  : {(num1 * 4 + (int)num2):f2}");

            Console.WriteLine($"El resultado del de la suma con decimales es  : {(num1 * 4 + num2):f4}");

            Console.ReadKey();

        }
    }
}
