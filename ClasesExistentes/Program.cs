using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesExistentes
{
    class Program
    {
        static void Main(string[] args)
        {
            //PEDIMOS UN NUMERO Y CALCULAMOS LA POTENCIA

            double num1, num2, value;


            Console.WriteLine("indique valor a calcular?");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("indique valor de la potencia?");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El valor de la potencia es {getPow(num1, num2)}");

        }

        static double getPow(double a, double b)
        {
            double potencia = Math.Pow(a,b);

            return potencia;
        }
    }
}
