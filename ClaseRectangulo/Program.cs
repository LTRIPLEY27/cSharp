using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsRectangulo rect1 = new ClsRectangulo();
            rect1.lado1 = 12;
            rect1.lado2 = 10;

            Console.WriteLine("el area del rectangulo es: " + rect1.CalculaArea());

            ClsRectangulo rect2 = new ClsRectangulo(14, 25);

            Console.WriteLine("el area del rectangulo es " + rect2.CalculaPerimetro());
        }
    }
}
