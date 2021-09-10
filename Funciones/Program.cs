using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // FUNCIONES
            //amb return i parametros

            int num1 = 4, num2 = 4;

            Console.WriteLine("el area del cuadrado de: {0} es {1}", num1, Cuadrado(num1)); //LLAMADO DE LA FUNCION

            // SIN RETURN Y SIN PARAMETROS

            string name = "jorge";
            Saluda(name);
            Saluda1();

            Console.WriteLine("indique su nombre?");
            string nombre = Console.ReadLine(); 
            ByeBye(nombre);


         
            Console.WriteLine("indique el valor 1?");
            float a = (float) Convert.ToInt32(Console.ReadLine()); // ES RECOMENDABLE CON UN FLOAT CASTEARLO ADEMAS DE CONVERT

            Console.WriteLine("indique el valor 2?");
            float b = (float) Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La media es : {(Media(a,b)):f3}");

            Console.ReadKey();
        }

        //MODIFICADOR DE ACCESO, EL TIPO DE VALOR QUE DEVUELVE, EL NOMBRE DE LA FUNCION (TIPO Y NOMBRE DE PARAMETROS QUE NECESITA)

        //static: NO NECESITA LA INSTANCIA DE UN OBJETO PARA SER LLAMADA
        static int Cuadrado(int num)
        {
            return num * num;
        }

        static void Saluda(string name) // CON PARAMETROS
        {
            Console.WriteLine("Hola " + name );
        }

        // SIN PARAMETROS

        static void Saluda1() 
        {
            Console.WriteLine("Hola ");
        }

        static void ByeBye(string n)
        {
            Console.WriteLine($"Bye {n}");
        }

        static float Media(float x, float z)
        {
            return ((x + z)/2.0f);
        }

        //funcion que reciba dos float y devuelva la media de los mismos.
    }
}
