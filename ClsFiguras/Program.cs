using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREAR INSTANCIA CON CADA UNO DE LOS CONTRUCTORES

            ClsCirculo circle = new ClsCirculo();

            circle.radio = 2;

            Console.WriteLine($"el area del circulo es: {circle.CalcularArea()}" );

            ClsCirculo circle1 = new ClsCirculo(8);

            Console.WriteLine("El perimetros es " +  circle1.CalcularPerimetro());

            ClsTriangulo triangle = new ClsTriangulo(4,8); // 1ER METODO
            Console.WriteLine($"la base {triangle.baseTri} y la altura {triangle.altura} del triangulo1");

            ClsTriangulo triangle1 = new ClsTriangulo(5); // 2do CONSTRUCTOR INICIALIZA BASE Y ALTURA = 5

            Console.WriteLine($"la base {triangle1.baseTri} y la altura {triangle1.altura} del triangulo2");

            ClsTriangulo triangle2 = new ClsTriangulo(0, 4); // 3er constructor, BASE = 4

            Console.WriteLine($"la base {triangle2.baseTri} y la altura {triangle2.altura} del triangulo3");

            Console.WriteLine($"el area del trinagulo es igual a {triangle.CalculaArea()}");



            Console.ReadKey();
        }
    }
}
