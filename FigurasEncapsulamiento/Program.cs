using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indique el radio de la circunferencia para calcular su area");

            double radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("indique la base triangulo");

            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("indique la altura del triangulo");

            double ladoB = Convert.ToDouble(Console.ReadLine());

            ClsCirculo circle = new ClsCirculo(radio);

            Console.WriteLine(circle.toString());

            ClsTriangulo triangle = new ClsTriangulo(ladoA, ladoB);

            Console.WriteLine(triangle.toString());

        }
    }
}
