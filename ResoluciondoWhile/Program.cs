using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoluciondoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int k = 0;

            Console.WriteLine("Indique su nombre");
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("Indique su nombre");
                name = Console.ReadLine();

            } while (!(name == "pepita"));

            Console.WriteLine("Bienvenida pepita");

            ///   BREAK AND CONTINUE
            /* CONDICION DE SALIDA CON UN BREAK */

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"vamos por {i}");
                if(i == 4)
                {
                    Console.WriteLine("esta es la salida {0}", i);
                    Console.WriteLine("Adeu...");
                    break;
                }
            }

            while (k < 3) 
            {
                Console.WriteLine($"vamos por aca");
                if(k == 2)
                {
                    Console.WriteLine("soy penultimo {0} elemento, ya puedes dilucidar la longitud", k);
                    k++;
                    continue;
                    
                }
                k++;
            }


        }
    }
}
