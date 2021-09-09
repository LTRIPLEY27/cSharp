using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string cadena = "hola mundo", name;

            // FOR SIMPLE

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("vamos por la iteracion{0}", i);

            }


            // FOR ANIDADO

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine("vamos por la iteracion {0}, {1}", i , k);
                }
            }

            // FOREACH

            foreach (char letra in cadena)  // EL FOR EACH ESTA SEPARANDO EN CARACTERES LA CADENA E IMPRIMIENDO CADA ITERACION
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("nombre");
            name = Console.ReadLine();

            // WHILE

            while( name != "pepita")
            {
                Console.WriteLine("name");
                name = Console.ReadLine();
            }

            // DO WHILE

            do
            {
                Console.WriteLine("name");
                name = Console.ReadLine();

            } while ( name != "pepita");

        }
    }
}
